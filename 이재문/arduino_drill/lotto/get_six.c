#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <windows.h>

#undef random
#define random() ((double)rand() / (RAND_MAX + 1))

int getNumFrom45(double x)
{
    if (0 <= x && x < 2.22)
        return 1;
    else if (x < 4.44)
        return 2;
    else if (x < 6.66)
        return 3;
    else if (x < 8.88)
        return 4;
    else if (x < 11.1)
        return 5;
    else if (x < 13.32)
        return 6;
    else if (x < 15.54)
        return 7;
    else if (x < 17.76)
        return 8;
    else if (x < 19.98)
        return 9;
    else if (x < 22.2)
        return 10;
    else if (x < 24.42)
        return 11;
    else if (x < 26.64)
        return 12;
    else if (x < 28.86)
        return 13;
    else if (x < 31.08)
        return 14;
    else if (x < 33.3)
        return 15;
    else if (x < 35.52)
        return 16;
    else if (x < 37.74)
        return 17;
    else if (x < 39.96)
        return 18;
    else if (x < 42.18)
        return 19;
    else if (x < 44.4)
        return 20;
    else if (x < 46.62)
        return 21;
    else if (x < 48.84)
        return 22;
    else if (x < 51.06)
        return 23;
    else if (x < 53.28)
        return 24;
    else if (x < 55.5)
        return 25;
    else if (x < 57.72)
        return 26;
    else if (x < 59.94)
        return 27;
    else if (x < 62.16)
        return 28;
    else if (x < 64.38)
        return 29;
    else if (x < 66.6)
        return 30;
    else if (x < 68.82)
        return 31;
    else if (x < 71.04)
        return 32;
    else if (x < 73.26)
        return 33;
    else if (x < 75.48)
        return 34;
    else if (x < 77.7)
        return 35;
    else if (x < 79.92)
        return 36;
    else if (x < 82.14)
        return 37;
    else if (x < 84.36)
        return 38;
    else if (x < 86.58)
        return 39;
    else if (x < 88.8)
        return 40;
    else if (x < 91.02)
        return 41;
    else if (x < 93.24)
        return 42;
    else if (x < 95.46)
        return 43;
    else if (x < 97.68)
        return 44;
    else if (x <= 1)
        return 45;
}

int getSixNum()
{
    int res[6] = {0, 0, 0, 0, 0, 0};
    int i;
    int temp = 0;

    for (i = 0; i < 6; i++)
    {
        temp = getNumFrom45(random());
        res[i] = temp;
        for (int j = 0; j < i; j++)
        {
            if (res[j] == temp) // check duplication
            {
                i--;
                break;
            }
        }
    }
    for (i = 0; i < 6; i++)
    {
        // Sleep(500);
        printf("[");
        // setTextBallColor(res[i]);
        printf("%2d", res[i]);
        // SetColor(7);
        printf("]");
    }
    printf("\n\n");
    return 0;
}

int main(void)
{
    int opt = -1;
    srand((unsigned)time(NULL));

    while (1)
    {
        scanf_s("%d", &opt);
        if (opt == 1)
            getSixNum();
        else if (opt == 0)
            break;
        system("pause");
    }

    return 0;
}