## Задача
* ["hello", "2", "world", ":-)"] --> ["2", ":-)"];
* ["1234", "1567", "-2", "computer science"] --> ["-2"];
* ["Russia", "Denmark", "Kazan"] --> [];

## Собственно, как я решал задачу:
1. Поскольку массивы у нас определенной неизменной заданной длины, создал временный массив той же длины, что и заданный.
2. Отсортировал строки (нашел в  заданном массиве и записал вначало временного массива строки с нужными параметрами).
3. Обрезал лишнее (создал результирующий массив с колличеством элементов равным колличеству элементов, записанных во временный массив; 
и, соответственно, все эти элементы в него и записал).
4. Вывел в консоль последовательно заданный массив -->  временный массив --> результирующий массив.
5. Оформил решение в виде отдельного метода.