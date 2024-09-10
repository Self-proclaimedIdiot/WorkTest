# This is a sample Python script.

# Press Shift+F10 to execute it or replace it with your code.
# Press Double Shift to search everywhere for classes, files, tool windows, actions, and settings.
import enum
import random
class seniority(enum.Enum):
    six = 0
    seven = 1
    eight = 2
    nine = 3
    ten = 4
    jack = 5
    queen = 6
    king = 7
    ace = 8
class suit(enum.Enum):
    hearts = 0
    diamonds = 1
    spades = 2
    clubs = 3
class Card:
    def __init__(self, seniority, suit):
        self.seniority = seniority
        self.suit = suit
    @staticmethod
    def init_deck():
        s = []
        for i in range(4):
            for j in range(9):
                s.append(Card(seniority(j), suit(i)))
        return s
    @staticmethod
    def shuffle_deck(s):
        for i in range(100):
            a = random.randint(0,35)
            b = random.randint(0,35)
            c = Card(s[a].seniority, s[a].suit)
            s[a].seniority = s[b].seniority
            s[a].suit = s[b].suit
            s[b].seniority = c.seniority
            s[b].suit = c.suit

# Press the green button in the gutter to run the script.
if __name__ == '__main__':
    s = Card.init_deck()
    Card.shuffle_deck(s)
# See PyCharm help at https://www.jetbrains.com/help/pycharm/
