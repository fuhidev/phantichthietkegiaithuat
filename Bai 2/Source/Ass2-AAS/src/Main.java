
import java.util.LinkedList;
import java.util.List;
import java.util.Random;

public class Main {
	private static int NUM = 5;
	private static int MAX = 380;
	private static int MAXVALUE = 1000;
	private static int POINT_A = 0;
	private static int POINT_B = 1;
	private static int VALUE = 2;

	private static int[] generatePoint() {
		Random random = new Random();
		int[] arc = new int[3];
		arc[POINT_A] = random.nextInt(MAX - 1);
		do {
			arc[POINT_B] = random.nextInt(MAX);
		} while (arc[POINT_B] <= arc[POINT_A]);
		arc[VALUE] = random.nextInt(MAXVALUE);
		return arc;
	}

	private static List<ARC> initCircle() {
		
		List<ARC> arcs = new LinkedList<ARC>();
		for (int i = 0; i < NUM; i++) {
			int[] arc = generatePoint();
			arcs.add(new ARC(arc[POINT_A],arc[POINT_B],arc[VALUE]));
		}
		return arcs;
	}

	public static void main(String[] args) {
		List<ARC> arcs = initCircle();
		/*List<ARC2> arcs = new LinkedList<ARC2>();
		arcs.add(new ARC2(156, 211, 990));
		arcs.add(new ARC2(277, 316, 547));
		arcs.add(new ARC2(125, 317, 651));
		arcs.add(new ARC2(340, 344, 596));
		arcs.add(new ARC2(343, 349, 369));*/
		Algorithms.OrderByPointB(arcs);
		System.out.println(arcs);
		System.out.println(Algorithms.BestNumberOfRequest(arcs));
//		List<ARC2> arc2s= initCircleB();
//		System.out.println(arc2s);
		System.out.println(Algorithms.BestGrossProfit(arcs));
	}
}
