package prog_lab_7;

public class main {
	public static void main(String args[]) {
		try {
			segments sm = new segments(-1);
			System.out.println("Object was successfully created");
			sm.vivod();		
		}
		catch(Exception ex){
			System.out.println("Error. Object wasn't created");
			System.out.println(ex);
		}
   }
}