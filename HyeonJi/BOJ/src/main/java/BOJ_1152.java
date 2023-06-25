import java.util.*;

public class BOJ_1152 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner in = new Scanner(System.in);
		 
		String S = in.nextLine();
		in.close();

		StringTokenizer st = new StringTokenizer(S," ");
		System.out.println(st.countTokens());
	}

}
