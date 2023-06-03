import java.util.Scanner;

public class BOJ_11945 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner sc = new Scanner(System.in);
		int a, b;
		a = sc.nextInt();
		b = sc.nextInt();
		for (int i = 0; i < a; i++) {
			while(sc.hasNext()) {
				StringBuilder sb = new StringBuilder(sc.next());
				sb.setLength(b);
				System.out.println(sb.reverse());
			}
		}
	}

}
