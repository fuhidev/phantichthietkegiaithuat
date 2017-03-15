public class ARC implements Comparable<ARC> {
	public int pointA;
	public int pointB;
	public int value;

	public ARC(int pointA, int pointB, int value) {
		super();
		this.pointA = pointA;
		this.pointB = pointB;
		this.value = value;
	}

	@Override
	public int compareTo(ARC o) {
		// TODO Auto-generated method stub
		/*int v1 = value / (pointB - pointA);
		int v2 = o.value / (o.pointB - o.pointA);
		if (v1 < v2)
			return 1;
		if (v1 > v2)
			return -1;
		return 0;*/
		if(this.pointB > o.pointB)
			return 1;
		if(this.pointB < o.pointB)
			return -1;
		return 0;
	}

	@Override
	public String toString() {
		// TODO Auto-generated method stub
		float percent = value / (pointB - pointA);
		return "Point A: " + pointA + ";Point B: " + pointB + ";Value :"
				+ value + ";Percent: "+percent+"\n";
	}
}
