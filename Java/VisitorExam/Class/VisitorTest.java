package exam2023_09_20.visitor;

public class VisitorTest {
	public static void main(String[] args) {
		var instance1 = new InstanceEntity();
		var instance2 = new InstanceEntity();
		var class1 = new ClassEntity("C1", instance1);
		var class2 = new ClassEntity("C2", instance2);
		var class3 = new ClassEntity("C3", class1, class2);
		assert class3.accept(new SuperClassOf(class3));
		assert class3.accept(new SuperClassOf(class1));
		assert class3.accept(new SuperClassOf(class2));
		assert !class1.accept(new SuperClassOf(class3));
		assert !class1.accept(new SuperClassOf(class2));
		assert !instance1.accept(new SuperClassOf(class3));
	}
}
