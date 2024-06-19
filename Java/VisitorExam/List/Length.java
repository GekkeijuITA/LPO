package exam2024_01_23.visitor;

public class Length implements Visitor<Integer> {

	@Override
	public Integer visitListCons(Exp head, ListExp tail) {
		return 1 + tail.accept(this);
	}

	@Override
	public Integer visitEmptyList() {
		return 0;
	}

}
