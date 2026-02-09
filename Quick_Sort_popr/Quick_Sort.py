def quick_sort(a, p, r):
    swaps = []  # Inicjalizacja listy swapów
    if p < r:
        q, new_swaps = partition(a, p, r)
        swaps.extend(new_swaps)
        swaps.extend(quick_sort(a, p, q))
        swaps.extend(quick_sort(a, q + 1, r))
    return swaps  # Zwracamy listę swapów (może być pusta)

def partition(a, p, r):
    x = a[p]
    i = p - 1
    j = r + 1
    swaps = []

    while True:
        j -= 1
        while a[j] > x:
            j -= 1
        i += 1
        while a[i] < x:
            i += 1
        if i < j:
            c = a[i]
            a[i] = a[j]
            a[j] = c
            swaps.append((i, j))
        else:
            return j, swaps

def main():
    a = list(map(int, input("Podaj elementy tablicy oddzielone spacją: ").split()))
    swaps = quick_sort(a, 0, len(a) - 1)

    for idx, (i, j) in enumerate(swaps[:3]):
        print(f"Swap nr: {idx} a[{i}] <-> a[{j}]")

if __name__ == "__main__":
    main()