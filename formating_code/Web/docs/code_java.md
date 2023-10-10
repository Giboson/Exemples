# code_java_1

```java
// Build Systen: IntelliJ 
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

## code_java_2

```java
// Build Systen: Maven 
package org.example;
import static java.lang.System.out;

public class Main {

    public static void main(String[] args) {
       
        out.printf(" WELCOME-> CODE! ");

        
        for (int i = 1; i <= 5; i++) {

            out.println("i = " + i);
        }
    }
}
```

## code_java_3

```java
// Build Systen: Maven  SERVER -- location >> http://localhost:8088/
package ru.geekbrainse;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.net.ServerSocket;
import java.net.Socket;
import java.nio.charset.StandardCharsets;
import static java.lang.System.out;

public class WebServer {

    public static void main(String[] args) {
        try (ServerSocket serverSocket = new ServerSocket(8088)) {

            while(true) {
                Socket socket = serverSocket.accept();
                out.println("#New client connected!#");
                BufferedReader input = new BufferedReader(
                        new InputStreamReader(
                                socket.getInputStream(), StandardCharsets.UTF_8));

                PrintWriter output = new PrintWriter(socket.getOutputStream());

                while (!input.ready()) ;

                while (input.ready()) {
                    out.println(input.readLine());
                }

                output.println("HTTP/1.1 200 OK");
                output.println("Content-Type: text/html; charset=utf-8");
                output.println();
                output.println("<h1>Привет от сервера!</h1>");
                output.flush();

                input.close();
                output.close();
            }

        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}

```
