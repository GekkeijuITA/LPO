package exam2023_09_20.visitor;

public interface Visitor<T> {
	T visitClassEntity(String name, JavaEntity... entities);

	T visitInstanceEntity();
}
