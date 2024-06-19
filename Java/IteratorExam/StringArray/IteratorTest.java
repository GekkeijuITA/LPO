package exam2023_07_10.iterator;

public class IteratorTest {
	public static void main(String[] args) {
		var it = new StringArrayRevIterator(new String[] { "a", "b", "c" });
		while (it.hasNext())
			System.out.println(it.next()); // stampa le tre linee c b a
		it = new StringArrayRevIterator("one", "two", "three");
		while (it.hasNext())
			System.out.println(it.next()); // stampa le tre linee three two one
		it = new StringArrayRevIterator(new String[0]);
		while (it.hasNext())
			System.out.println(it.next()); // non stampa nulla
	}
}
