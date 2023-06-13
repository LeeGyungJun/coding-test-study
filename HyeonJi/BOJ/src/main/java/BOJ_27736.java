import java.util.Scanner;

public class BOJ_27736 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner sc = new Scanner(System.in);
		int n = sc.nextInt();
		int appr = 0, rjct = 0, inv = 0;
		for(int i = 0; i < n; i++) {
			int j = sc.nextInt();
			if(j > 0) appr++;
			else if(j < 0) rjct++;
			else inv++;
		}
		int m = 0;
		if(n%2 != 0) {
			m = (n/2) + 1;
		}else {
			m = n/2;
		}
		
		if(inv >= m) {
			System.out.print("INVALID");
		}else if(appr > rjct) {
			System.out.print("APPROVED");
		}else {
			System.out.print("REJECTED");
		}
	}

}
