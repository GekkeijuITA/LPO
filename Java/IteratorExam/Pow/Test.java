package exam2022_06_20.iterators;

public class Test {

	public static void main(String[] args) {
		var it = new PowIterator(2, 3);
		while (it.hasNext())
			System.out.println(it.next());
		it.reset(-1, 4);
		while (it.hasNext())
			System.out.println(it.next());
	}
}
