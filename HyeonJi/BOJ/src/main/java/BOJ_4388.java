import java.util.*;
import java.io.*;

public class BOJ_4388 {

	public static void main(String[] args) throws IOException {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		
		while(true) {
			StringTokenizer st = new StringTokenizer(br.readLine());
			StringBuilder sb = new StringBuilder(st.nextToken());
			String N = sb.reverse().toString();
			sb = new StringBuilder(st.nextToken());
			String M = sb.reverse().toString();
			
			int Nsize = N.length();
			int Msize = M.length();
			
			//0 0입력 시 무한루프 종료
			if(N.equals("0") && M.equals("0")) {
				break;
			}
			
			int num = 0; //받아올릴 수
			int count = 0; //받아올림 횟수
			
			//두 문자열의 길이중 긴 길이만큼 반복
			for(int i = 0; i < Math.max(Nsize, Msize); i++) {
				int n = 0;
				int m = 0;
				
				if(i < Math.min(Nsize, Msize)) { //현재 연산할 자릿수가 아직 길이가 짧은 문자열의 길이를 넘지 않았으면 둘다 연산
					n = N.charAt(i) - '0';
					m = M.charAt(i) - '0';
					
				}else { //현재 연산할 자릿수가 아직 길이가 짧은 문자열의 길이를 넘었으면 길이가 긴 값만 연산
					//길이가 긴 값의 자릿값
					n = (Math.max(Nsize, Msize) == Nsize) ? N.charAt(i) - '0' : M.charAt(i) - '0';
				}
				//10이상이면 num에 1저장, count++
				if((n + m  + num) >= 10) {
					num = 1;
					count++;
				}else {
					num = 0;
				}
			}
			System.out.println(count);
		}
	}

}
