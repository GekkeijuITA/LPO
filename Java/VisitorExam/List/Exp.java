package exam2024_01_23.visitor;
public interface Exp {
	<T> T accept(Visitor<T> v);
}
