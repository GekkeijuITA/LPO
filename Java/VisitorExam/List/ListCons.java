package exam2024_01_23.visitor;

import static java.util.Objects.requireNonNull;;

public class ListCons implements ListExp {
	private final Exp head; // invariant head != null
	private final ListExp tail; // invariant tail != null

	public ListCons(Exp head, ListExp tail) {
		this.head = requireNonNull(head);
		this.tail = requireNonNull(tail);
	}

	@Override
	public <T> T accept(Visitor<T> v) {
		return v.visitListCons(head, tail);
	}

}
