package exam2022_06_20.iterators;

import java.util.Iterator;
import java.util.NoSuchElementException;

public class PowIterator implements Iterator<Integer> {

	private int base; // invariant: base != 0
	private int next = 1; // prossimo elemento da restituire
	private int size; // numero elementi da restituire, nessun elemento se size<=0

	protected static int checkBase(int base) { 
		if (base == 0)
			throw new IllegalArgumentException("Base cannot be zero");
		return base;
	}

	public PowIterator(int base, int size) { 
		this.base = checkBase(base); 
		this.size = size; 
	}

	@Override
	public boolean hasNext() { 
		return size > 0;
	}

	@Override
	public Integer next() {
		if (!hasNext())
			throw new NoSuchElementException();
		var res = next;
		next *= base;
		size--;
		return res;
	}

	public void reset(int base, int size) { 
		this.base = checkBase(base);
		this.next = 1;
		this.size = size;
	}

}
