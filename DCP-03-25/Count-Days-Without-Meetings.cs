public class Solution {
    public int CountDays(int days, int[][] meetings) {
        Array.Sort(meetings, (a, b) => a[0].CompareTo(b[0]));

        List<int[]> mergedMeetings = new List<int[]>();
        foreach (var meeting in meetings) {
            if (mergedMeetings.Count == 0 || meeting[0] > mergedMeetings[^1][1]) {
                mergedMeetings.Add(meeting);
            } else {
                mergedMeetings[^1][1] = Math.Max(mergedMeetings[^1][1], meeting[1]);
            }
        }

        int meetingDaysCount = 0;
        foreach (var m in mergedMeetings) {
            meetingDaysCount += (m[1] - m[0] + 1);
        }

        return days - meetingDaysCount;
    }
}