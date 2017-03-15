import java.util.Collections;
import java.util.LinkedList;
import java.util.List;

public class Algorithms {
/*
 * Thuật toán sắp xếp theo điểm kết thúc
 */
	public static boolean OrderByPointB(List<ARC> lstARC) {
		if (lstARC == null || lstARC.size() == 0)
			return false;
		;
		Collections.sort(lstARC);
		return true;
	}
	/*
	 * Thuật toán chọn lựa những yêu cầu trong loạt yêu cầu chồng chất mà sao cho đáp ứng được nhiều yêu cầu nhất
	 */
	public static List<ARC> BestNumberOfRequest(List<ARC> lstARC) {
		// OrderByPointB(lstARC);
		List<ARC> lstResult = new LinkedList<ARC>();
		lstResult.add(lstARC.get(0));
		for (int i = 1; i < lstARC.size(); i++) {
			ARC lastResult = lstResult.get(lstResult.size() - 1);
			ARC current = lstARC.get(i);
			if (current.pointA >= lastResult.pointB) {
				lstResult.add(current);
			}
		}
		return lstResult;
	}

	static int max(int a, int b) {
		if (a > b)
			return a;
		return b;
	}
/*
 * Thuật toán tìm giá trị lớn nhất trong những yêu cầu chồng chất
 */
	public static List<ARC> BestGrossProfit(List<ARC> lstARC) {

		List<ARC> lstResult = new LinkedList<ARC>();

		int n = lstARC.size();
		int[] V = new int[n];
		int[] L = new int[100];
		V[0] = 0;
		for (int i = 0; i < n; i++) {
			L[i] = lstARC.get(i).value;
			for (int j = 0; j < i; j++) {
				if ((lstARC.get(j).pointB <= lstARC.get(i).pointA)
						&& (L[i] < L[j] + lstARC.get(i).value)) {
					L[i] = L[j] + lstARC.get(i).value;
					V[i] = j;
				}
			}
		}
		int index = max(L);
		lstResult.add(lstARC.get(index));
		for (int i = index - 1; i >= 0; i--) {
			if ((L[index] - lstARC.get(index).value == L[i])) {
				lstResult.add(lstARC.get(i));
				index = i;
			}
		}
		return lstResult;
	}
/*
 * Tìm vị trí có giá trị lớn nhất trong mảng
 * Return: vị trí có giá trị lớn nhất
 */
	static int max(int[] L) {
		int max = L[0];
		int index = 0;
		for (int i = 1; i < L.length; i++) {
			if (L[i] > max) {
				max = L[i];
				index = i;
			}
		}
		return index;
	}
}
