class Solution:
    def mergeArrays(self, nums1: List[List[int]], nums2: List[List[int]]) -> List[List[int]]:
        s1 = dict(nums1)
        s2 = dict(nums2)
        merge = Counter(s1) + Counter(s2)
        merge = sorted(merge.items())
        res = list(merge)
        return res
