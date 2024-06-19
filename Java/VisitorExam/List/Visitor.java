package exam2024_01_23.visitor;

public interface Visitor<T> {
	T visitListCons(Exp head, ListExp tail);

	T visitEmptyList();
}
