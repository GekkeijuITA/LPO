package exam2023_09_20.visitor;

public class InstanceEntity implements JavaEntity {

	@Override
	public <T> T accept(Visitor<T> v) {
		return v.visitInstanceEntity();
	}

}
