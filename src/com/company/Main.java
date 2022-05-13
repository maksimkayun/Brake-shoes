package com.company;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Main {
    private static List<String> mvps = new ArrayList<>();
    private static List<String> numbers = new ArrayList<>();

    public static void main(String[] args) {
        for (int i = 0; i < 2; i++) {
            System.out.println("ЧАСТЬ " + (i + 1));
            work();
        }
    }

    public static void work() {
        mvps.clear();
        numbers.clear();
        Scanner sc = new Scanner(System.in);

        System.out.print("Введите количество полей типа Номер МВПС (ЭД4М - 0091): ");
        int N = Integer.parseInt(sc.nextLine());

        for (int i = 0; i < N; i++) {

            mvps.add(sc.nextLine().trim().replaceAll(" ", ""));
        }

        System.out.println("\nВведите номера ТБ аналогично (без количества): ");
        for (int i = 0; i < N; i++) {
            numbers.add(sc.nextLine());
        }

        System.out.println("\nРезультат:");
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < N; i++) {
            sb.append(mvps.get(i) + " тормозные башмаки №№" + numbers.get(i) + " в наличии сверены с книгой учета " +
                    "ПУ-80 и соответствуют описи, находящейся на электропоезде.\n");
        }

        System.out.println(sb);
    }
}
