# Celsius to Fahrenheit (c2f)

First programming exercise in Chapter 2 of textbook.

Not assigned in class, but I'm keeping up my GitHub streak.

I'm not supposed to use a for loop (yet), but I wanted to see a column of numbers.

As a bonus, I remembered that the second programming example (indeed, the first
after the famous and oft-imititated "Hello World") in Kernighan & Ritchie's classic
1978 textbook "The C Programming Language" was actually a Fahrenheit to Celsius
conversion, so I included a C# variant of that algorithm in this solution.

The differences are minor. I declared `LOWER`, `UPPER`, and `STEP` as constants
(C allows that too, but Kernighan and Ritchie kept their example very simple) and
there are differences between `sprintf()` and `WriteLine()` string formatting.

## Example output
```
 Celsius  Fahrenheit
       0        32.0
       1        33.8
       2        35.6
       3        37.4
       4        39.2
       5        41.0
       6        42.8
       7        44.6
       8        46.4
       9        48.2
      10        50.0
      11        51.8
      12        53.6
      13        55.4
      14        57.2
      15        59.0
      16        60.8
      17        62.6
      18        64.4
      19        66.2
      20        68.0
      21        69.8
      22        71.6
      23        73.4
      24        75.2
      25        77.0
      26        78.8
      27        80.6
      28        82.4
      29        84.2
      30        86.0
      31        87.8
      32        89.6


  Fahrenheit Celsius
           0     -17
          20      -6
          40       4
          60      15
          80      26
         100      37
         120      48
         140      60
         160      71
         180      82
         200      93
         220     104
         240     115
         260     126
         280     137
         300     148
```
