package exam2024_01_23.visitor;

public class EmptyList implements ListExp {

	@Override
	public <T> T accept(Visitor<T> v) {
		return v.visitEmptyList();
	}

}
