import java.util.Scanner;

public class BOJ_18883 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner sc = new Scanner(System.in);
		int n = sc.nextInt();
		int m = sc.nextInt();
		int cnt = 1;
		StringBuilder sb = new StringBuilder();
		for(int i = 0; i < n; i++) {
			for(int j = 0; j < m; j++) {
				if(j == m-1) {
					sb.append(cnt++ + "\n");
				}else {
					sb.append(cnt++ + " ");
				}
			}
		}
		System.out.println(sb);
	}

}
