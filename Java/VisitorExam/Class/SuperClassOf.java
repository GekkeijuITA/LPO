package exam2023_09_20.visitor;
import static java.util.Objects.requireNonNull;
public class SuperClassOf implements Visitor<Boolean> {
	private final ClassEntity classEntity;
	public SuperClassOf(ClassEntity classEntity) {
		this.classEntity = requireNonNull(classEntity);
	}
	@Override
	public Boolean visitClassEntity(String name, JavaEntity... entities) {
		if (name.equals(classEntity.getName()))
			return true;
		for (var e : entities) {
			if (e.accept(this))
				return true;
		}
		return false;
	}
	@Override
	public Boolean visitInstanceEntity() {
		return false;
	}
}
