package exam2024_01_23.visitor;
public class VisitorTest {
	public static void main(String[] args) {
		var l1 = new EmptyList(); // la lista []
		var l2 = new ListCons(l1, l1); // la lista [[]]
		var l3 = new ListCons(l1, l2); // la lista [[];[]]
		Length length = new Length();
		assert l1.accept(length) == 0;
		assert l2.accept(length) == 1;
		assert l3.accept(length) == 2;
	}
}
