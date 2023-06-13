import java.util.Scanner;

public class BOJ_5565 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner sc = new Scanner(System.in);
		int total = sc.nextInt();
		int amtTot = 0;
		for(int i=0; i < 9; i++) {
			int bookAmt = sc.nextInt();
			amtTot += bookAmt;
		}
		System.out.print(total-amtTot);
	}

}
