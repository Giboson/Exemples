# code_java_1

```java
import java.util.Arrays;
import java.util.List;
import static java.lang.System.out;

class Welcome {
    public static void main(String[] args) {
        int[] array = {5, 6, 7, 8};
       out.println(" WELCOME! -> array " + Arrays.toString(array) + " is " + findAverage(array));
    }

    public static double findAverage(int[] values) {
        double result = 0;
        for (int i = 0; i < values.length; i++) {
            result += values[i];
        }
        return result;
    }
}


```
