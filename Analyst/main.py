import numpy as np
import random

from DataTransfer.DT import DT

class P:
    def __init__(self, name, age):
        self.name = name
        self.age = age
        self.values = [random.gauss(0, 1) for i in range(10)]

def main():
    dt = DT()
    p = [P('katya', 10), P('sasha', 15) ]

    dt.write(p)



if __name__ == '__main__':
    main()