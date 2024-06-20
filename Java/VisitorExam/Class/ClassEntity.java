package exam2023_09_20.visitor;
import static java.util.Objects.requireNonNull;
public class ClassEntity implements JavaEntity {
	private final String name;
	private final JavaEntity[] entities; // instances or subclasses
	public ClassEntity(String name, JavaEntity... entities) { // shallow copy
		this.name = requireNonNull(name);
		this.entities = requireNonNull(entities);
	}
	@Override
	public <T> T accept(Visitor<T> v) {
		return v.visitClassEntity(name, entities);
	}
	public String getName() {
		return name;
	}
}
