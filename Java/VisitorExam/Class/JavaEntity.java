package exam2023_09_20.visitor;
public interface JavaEntity {
	<T> T accept(Visitor<T> v);
}