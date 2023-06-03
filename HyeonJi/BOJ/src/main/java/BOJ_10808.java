import java.util.Scanner;

public class BOJ_10808 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner sc = new Scanner(System.in);
		String str = sc.next();
		int[] alphabet = new int[26];
		
		for (int i = 0; i < str.length(); i++) {
            int index = str.charAt(i) - (int) 'a';        //(int)'a'로 int형으로 형변환 한 a를 뺀 값을 index에 알파벳의 위치로 저장한다.
            alphabet[index]++;
        }
        for (int i = 0; i < alphabet.length; i++) {
            System.out.print(alphabet[i]+" ");
        }
	}

}
