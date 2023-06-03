import java.util.Scanner;

public class BOJ_11365 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner sc = new Scanner(System.in);
		while(sc.hasNext()) {
			String str = sc.nextLine();
			if("END".equals(str)) {
				sc.close();
				break;
			}else {
				StringBuilder sb = new StringBuilder();
				sb.append(str);
				System.out.println(sb.reverse());
			}
		}
	}

}
