import unittest


def swap_first_last_elements(list):
    list[0], list[-1] = list[-1], list[0]
    return list


def rem_last_element(list):
    list.remove(list[-1])
    return list


class TestListMethods(unittest.TestCase):
    def test_liubov_peleshenko_fi_94(self):
        list = [1, 2, 3, 4, 5, 6]
        self.assertEqual(swap_first_last_elements(list), [6, 2, 3, 4, 5, 1])

    def test_roman_tkalenko_fi_13(self):
        self.assertEqual(len([]), 0)
        self.assertEqual(len(['a']), 1)
        self.assertEqual(len(['a', 'b']), 2)

    def test_polina_kozarovitskaya(self):
        t = [1, 2, 3]
        t.clear()
        self.assertEqual(len(t), 0)

    def test_roman_tkalenko_2(self):
        self.assertEqual(2, 2)

    def test_Yegor_Panasuk_FI94(self):
        list = [1, 2, 3, 4, 5, 6]
        self.assertEqual(rem_last_element(list), [1, 2, 3, 4, 5])

    def test_michael_medved_fi93(self):
        self.assertEqual(len([] + ['f']), len('f'))

    def test_illia_kripaka_fi_94_2(self):
        self.assertEqual(2 * [1, 3, 5], [1, 3, 5, 1, 3, 5])

    def test_maria_martynova_fi_93(self):
        self.assertEqual(len([0]), 1)
        self.assertEqual(len([1, 1]), 2)

    def test_kostiantyn_baievskyi_fi_93(self):
        self.assertEqual([1, 2, 3] + [4, 5, 6], [1, 2, 3, 4, 5, 6])

    def test_1_olia_futurska_fi94(self):
        listo1 = [1, 2, 3, 4, 5, 6, 7]
        listo2 = [1, 2, 3, 4, 6, 6, 7]
        self.assertIsNot(listo1[4], listo2[4])

    def test_kirill_kostiuk(self):
        self.assertEqual(len(['a', 'b'] + ['b']), 3)
        self.assertEqual(['a', 'b'] + ['b'], ['a', 'b', 'b'])


if __name__ == '__main__':
    unittest.main()
