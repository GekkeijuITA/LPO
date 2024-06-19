package exam2023_07_10.iterator;

import java.util.Iterator;
import java.util.NoSuchElementException;

import static java.util.Objects.requireNonNull;

public class StringArrayRevIterator implements Iterator<String> {

	private int index;
	private final String[] arr;

	public StringArrayRevIterator(String... arr) {
		this.arr = requireNonNull(arr);
		index = arr.length - 1;
	}

	@Override
	public boolean hasNext() {
		return index >= 0;
	}

	@Override
	public String next() {
		if (!hasNext())
			throw new NoSuchElementException();
		return arr[index--];
	}

}
