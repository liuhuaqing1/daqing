Imports System.Collections.Concurrent
Imports System.Text
Imports System.Threading
Module Module1
    Dim asd(80) As Date
    Private mm As Integer = 0
    Private XTtimer As New Threading.Thread(AddressOf XTtimer1)
    ''' <summary>
    ''' 记录在选机台界面的用户数组
    ''' </summary>
    Private dictSelectMachineUser As New ConcurrentDictionary(Of String, Integer)
    ''' <summary>
    ''' 游戏状态字典  key服务器标记  value状态/房间比例1/房间比例2/房间比例3/房间比例4
    ''' </summary>
    Private GameType As New ConcurrentDictionary(Of String, String)
    Sub Main()
        Dim _Day As String = 20
        Dim _Result As String = _Day.Substring(_Day.Length - 1, 1)
        Dim aa As String = "a"
        Dim bb As String = ":......................."
        'Console.WriteLine(aa.Split("?")(1))
        'Dim aa As String = "50:0.04:0.05,30:0.057:0.08,30:0.057:0.08,20:0.057:0.14,10:0.057:0.3,10:0.057:0.3,5:0.057:0.65,5:0.057:0.65,5:0.057:0.65$300:0.011:0.02,200:0.02:0.03,100:0.013:0.026,80:0.023:0.03,50:0.04:0.05,30:0.057:0.08,30:0.057:0.08,20:0.057:0.14,20:0.057:0.14$2000:0.000:0.000,800:0.003:0.003,600:0.005:0.005,100:0.013:0.026,100:0.013:0.026,80:0.023:0.03,80:0.023:0.03,50:0.04:0.05,50:0.04:0.05"
        'Dim _doubPl(35) As Double '临时赔率记录
        'Dim _doubGl(35) As Double '临时概率记录
        'Dim _doubMfGl(35) As Double '临时免费玩法的概率记录

        'Dim pl_gl() As String = aa.Split("$")
        'Dim pl_gl1() As String = pl_gl(0).Split(",")
        'Dim pl_gl2() As String = pl_gl(1).Split(",")
        'Dim pl_gl3() As String = pl_gl(2).Split(",")

        'Dim bii As Integer = 9
        'For j As Integer = 0 To pl_gl1.Length - 1
        '    Dim a01() As String = pl_gl1(j).Split(":")
        '    Dim a02() As String = pl_gl2(j).Split(":")
        '    Dim a03() As String = pl_gl3(j).Split(":")

        '    _doubPl(bii) = CDbl(a01(0)) ： _doubGl(bii) = CDbl(a01(1)) ： _doubMfGl(bii) = CDbl(a01(2)) ： bii += 1
        '    _doubPl(bii) = CDbl(a02(0)) ： _doubGl(bii) = CDbl(a02(1)) ： _doubMfGl(bii) = CDbl(a02(2)) ： bii += 1
        '    _doubPl(bii) = CDbl(a03(0)) ： _doubGl(bii) = CDbl(a03(1)) ： _doubMfGl(bii) = CDbl(a03(2)) ： bii += 1
        'Next
        'For i As Integer = 0 To _doubMfGl.Count - 1
        '    Console.WriteLine(_doubMfGl(i))
        'Next
        '  Console.WriteLine(_doubMfGl.Count)
        'Dim LoadLength As Byte = CSByte(128 And &H7F)
        'Dim aa As Byte = 255
        'Console.WriteLine(CByte(1))
        'For i As Integer = 1 To 100
        '    Console.WriteLine(i Mod 3)
        'Next

        'Dim aa As Integer = 10
        'For i As Integer = 0 To 10
        '    Dim bb As String = Guid.NewGuid.ToString
        '    Console.WriteLine(bb)
        'Next

        'Console.WriteLine("1")
        'Dim aa As String = "DF?"
        ' Console.Write(aa.Split("?")(0) & ":" & aa.Split("?")(2))
        'Select Case aa
        '    Case > 13
        '        Console.WriteLine("1")

        '    Case > 2
        '        Console.WriteLine("2")
        '    Case Else

        'End Select
        'Dim aa() As Integer = {}
        'Console.WriteLine(aa.Length)
        'ReDim aa(4)
        'Console.WriteLine(aa.Length)
        'Dim aa As Integer = 5
        'If aa > 1 Then
        '    Console.WriteLine("1")
        'ElseIf aa > 2 Then
        '    Console.WriteLine("2")

        'ElseIf aa > 3 Then
        '    Console.WriteLine("3")


        'End If


        ''查询游戏状态、房间比例是否有更新
        'Dim _dic As New ConcurrentDictionary(Of String, String)
        ''复制状态字典
        'For Each item As KeyValuePair(Of String, String) In GameType
        '    _dic.TryAdd(item.Key, item.Value)
        'Next
        'For Each item As KeyValuePair(Of String, String) In _dic
        '    Console.WriteLine("22")
        '    Console.WriteLine("Result" & item.Key & ":" & item.Value)
        '    '_dic.TryAdd(item.Key, item.Value)
        'Next
        'dictSelectMachineUser.TryAdd("1", 1)
        'dictSelectMachineUser.TryAdd("2", 2)
        'dictSelectMachineUser.TryRemove("1", dictSelectMachineUser("1"))
        'dictSelectMachineUser.TryAdd("3", 3)
        'Dim aa As Integer = 0


        'Dim TempMachineMultiple As String = "1,2,3,4"
        ''循环80个机台赋值机台比例
        'For i As Integer = 1 To 80

        '    Dim douBS = TempMachineMultiple.Split(",")((i - 1) \ 20)
        '    Console.WriteLine(douBS)
        'Next



        'If Not dictSelectMachineUser.ContainsKey("11") Then
        '    '添加该用户到选机台用户信息中
        '    dictSelectMachineUser.TryAdd("11", 11)

        'End If
        'If Not dictSelectMachineUser.ContainsKey("22") Then
        '    '添加该用户到选机台用户信息中
        '    dictSelectMachineUser.TryAdd("22", 22)

        'End If
        'Dim mm As Boolean = False
        'If dictSelectMachineUser.ContainsKey("11") Then
        '    Dim ii As Integer = dictSelectMachineUser("11")
        '    '从选机台用户中移除该用户
        '    mm = dictSelectMachineUser.TryRemove("11", ii)
        'End If
        ''Console.WriteLine(mm)
        'For Each item As KeyValuePair(Of String, Integer) In dictSelectMachineUser
        '    'Console.WriteLine(item.Key & item.Value)
        'Next
        'Dim randomNum1 As Integer = (Rng.RandomDouble(1) * 10000000)
        'Dim randomNum2 As Integer = (Rng.RandomDouble(1) * 100000000)
        ''Console.WriteLine(randomNum1.ToString & randomNum2.ToString)
        'Dim err As String = "Err"
        ''Console.WriteLine(err.ToLower)
        'Dim nn As Double = 30
        'Dim num As Double = 7.5 / nn * 1500 / 3000


        'Dim times As String = "1964-1-1"
        'Dim seconds As Double = DateTime.Now.Subtract(DateTime.Parse(times)).TotalSeconds
        'For i As Integer = 1 To 12
        '    For j As Integer = 1 To 28
        '        Dim _time() As String = times.Split("-")
        '        If seconds > 166021184631755 Then
        '            Console.WriteLine(i & "1" & j)
        '            Console.ReadKey()
        '            Exit Sub
        '        Else

        '            seconds = DateTime.Now.Subtract(DateTime.Parse("1965-" & i & "-" & j)).TotalSeconds
        '        End If
        '    Next
        'Next
        'Dim randomNum As Double = DateTime.Now.Subtract(DateTime.Parse("1963-7-26")).TotalSeconds
        'Dim days As Integer = (168021193144474 / 60 / 60 / 24 / 1000)
        ''Console.WriteLine(randomNum / 60 / 60 / 24)
        ''Console.WriteLine(days / 100)
        'Dim str As String = "50:0.04:0.05,30:0.057:0.08,30:0.057:0.08,20:0.057:0.14,10:0.057:0.3,10:0.057:0.3,5:0.057:0.65,5:0.057:0.65,5:0.057:0.65$300:0.011:0.02,200:0.02:0.03,100:0.013:0.026,80:0.023:0.03,50:0.04:0.05,30:0.057:0.08,30:0.057:0.08,20:0.057:0.14,20:0.057:0.14$2000:0.001:0.001,800:0.003:0.003,600:0.005:0.005,100:0.013:0.026,100:0.013:0.026,80:0.023:0.03,80:0.023:0.03,50:0.04:0.05,50:0.04:0.05"
        'Dim _doubMfGl As String = "0.03\0.01\0.0016\0.04\0.012\0.004\0.08\0.02\0.006\0.12\0.025\0.008\0.2\0.04\0.012\0.2\0.06\0.02\0.4\0.06\0.02\0.4\0.08\0.025\0.6\0.1\0.03\0.6\0.12\0.04"
        'Dim doubMfGl(35) As Double
        'For i As Integer = 0 To 29

        '    If i > 2 Then
        '        doubMfGl(i + 6) = _doubMfGl.Split("\")(i)
        '    Else
        '        doubMfGl(i) = _doubMfGl.Split("\")(i)
        '    End If
        '    ' Console.WriteLine(doubMfGl(i))
        'Next
        'Dim str22 As String = "asdf"
        ''Console.WriteLine(str22.Split(":")(0))
        'Dim str23 As Boolean = False
        'Console.WriteLine(str23.ToString)
        'Dim strrr As String = "dddddd"
        'Dim str2323 As String = "80:0.015\250:0.005\500:0.0008\60:0.02\200:0.006\400:0.002\30:0.04\150:0.01\350:0.003\20:0.06\100:0.012\300:0.004\15:0.1\60:0.02\200:0.006\15:0.1\50:0.03\150:0.01\10:0.2\40:0.03\120:0.01\10:0.2\30:0.04\100:0.012\5:0.3\25:0.05\80:0.015\5:0.3\20:0.06\60:0.02"
        'Console.WriteLine(str2323.Split("\").Count)
        'Dim str1 As String = "0,0,0,0,2,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0"
        'Dim doub As Double = 2.55665221445
        'Dim mm As Date = Now
        'Format(doub, "0.00")
        'Console.WriteLine((Now - mm).TotalMilliseconds)
        'mm = Now
        'liangwei1(doub)
        'Console.WriteLine((Now - mm).TotalMilliseconds)
        'Dim mm As String = "50:0.04:0.05,30:0.057:0.08,30:0.057:0.08,20:0.057:0.14,10:0.057:0.3,10:0.057:0.3,5:0.057:0.65,5:0.057:0.65,5:0.057:0.65$300:0.011:0.02,200:0.02:0.03,100:0.013:0.026,80:0.023:0.03,50:0.04:0.05,30:0.057:0.08,30:0.057:0.08,20:0.057:0.14,20:0.057:0.14$2000:0.000:0.000,800:0.003:0.003,600:0.005:0.005,100:0.013:0.026,100:0.013:0.026,80:0.023:0.03,80:0.023:0.03,50:0.04:0.05,50:0.04:0.05"
        'Dim _doubPl(35) As Double '临时赔率记录
        'Dim _doubGl(35) As Double '临时概率记录
        'Dim _doubMfGl(35) As Double '临时免费玩法的概率记录

        'Dim pl_gl() As String = mm.Split("$")
        'Dim pl_gl1() As String = pl_gl(0).Split(",")
        'Dim pl_gl2() As String = pl_gl(1).Split(",")
        'Dim pl_gl3() As String = pl_gl(2).Split(",")

        'Dim bii As Integer = 9
        'For j As Integer = 0 To pl_gl1.Length - 1
        '    Dim a01() As String = pl_gl1(j).Split(":")
        '    Dim a02() As String = pl_gl2(j).Split(":")
        '    Dim a03() As String = pl_gl3(j).Split(":")

        '    _doubPl(bii) = CDbl(a01(0)) ： _doubGl(bii) = CDbl(a01(1)) ： _doubMfGl(bii) = CDbl(a01(2)) ： bii += 1
        '    _doubPl(bii) = CDbl(a02(0)) ： _doubGl(bii) = CDbl(a02(1)) ： _doubMfGl(bii) = CDbl(a02(2)) ： bii += 1
        '    _doubPl(bii) = CDbl(a03(0)) ： _doubGl(bii) = CDbl(a03(1)) ： _doubMfGl(bii) = CDbl(a03(2)) ： bii += 1
        'Next
        'Dim doubMfGl(35) As Double
        'doubMfGl = _doubMfGl
        'Console.WriteLine(mm.Length)
        'For i As Integer = 0 To doubMfGl.Count - 1
        '    Console.WriteLine(doubMfGl(i))
        'Next

        'For i = 1 To 100
        '    ' Console.WriteLine(getRandom({0.9, 0.8, 0.5, 0.3}))
        'Next
        'Dim ByteList As List(Of Byte) = Encoding.UTF8.GetBytes(-1).ToList
        'For Each mm As Byte In ByteList
        '    Console.WriteLine(mm)
        'Next
        '' Console.WriteLine(CInt(False))
        Console.ReadKey()
    End Sub
    Function getRandom(ByVal doub() As Double) As Double
        Try
            '充值随机函数
            Randomize()
            For i As Integer = 0 To doub.Length - 1
                '随机获取概率
                Dim r As Double = Rng.RandomDouble(1)
                '获取对应下标
                If (r <= doub(i)) Then
                    Return i + 1
                End If
            Next
        Catch ex As Exception
            'errLog("生成概率错误getRandom 错误：", ex.ToString, ex)
        End Try
        Return 0
    End Function
    Function liangwei1(ByVal Dou As Double) As String
        Dim mypercent2 As Double = 0
        Dim NumStr As String = ""
        Try
            mypercent2 = Math.Round(Dou, 2)
            If mypercent2 = CInt(mypercent2) Then
                NumStr = CInt(mypercent2)
            Else
                NumStr = mypercent2
            End If
        Catch ex As Exception
            'errLog("保留2为小数时 错误：", "Dou=" & Dou & "|NumStr=" & NumStr, New Exception)
        End Try
        Return NumStr
    End Function
    Public Sub XTtimer1()

        While True
            mm = -100
            Thread.Sleep(0.01)
        End While


    End Sub
    Function liangwei(ByVal Dou As Double) As String
        Dim mypercent2 As Double = 0
        Dim NumStr As String = ""
        Try
            mypercent2 = Math.Round(Dou, 2)
            If mypercent2 = CInt(mypercent2) Then
                NumStr = CInt(mypercent2)
            Else
                NumStr = mypercent2
            End If
        Catch ex As Exception
        End Try
        Return NumStr
    End Function
    Function lx(ByVal r_dWinJackpot As Double, ByVal r_dTotalJackpot As Double, ByVal m As Integer) As String
        '判断下注分数
        Select Case m
            Case 8 To 15
                r_dWinJackpot = r_dTotalJackpot * 1 / 10
            Case 16 To 23
                r_dWinJackpot = r_dTotalJackpot * 2 / 10
            Case 24 To 31
                r_dWinJackpot = r_dTotalJackpot * 3 / 10
            Case 32 To 39
                r_dWinJackpot = r_dTotalJackpot * 4 / 10
            Case 40 To 47
                r_dWinJackpot = r_dTotalJackpot * 5 / 10
            Case 48 To 55
                r_dWinJackpot = r_dTotalJackpot * 6 / 10
            Case 56 To 63
                r_dWinJackpot = r_dTotalJackpot * 7 / 10
            Case 64 To 71
                r_dWinJackpot = r_dTotalJackpot * 8 / 10
            Case 72 To 79
                r_dWinJackpot = r_dTotalJackpot * 9 / 10
            Case 80
                r_dWinJackpot = r_dTotalJackpot
        End Select
        Dim r_dWinJackpot1 As Double = r_dTotalJackpot * (m \ 8) / 10
        Return r_dWinJackpot & "====" & r_dWinJackpot1
    End Function
    Class mmm
        Private Structure m1
            Private m As Integer
            Private n As Integer
        End Structure
        Private a As Integer

        Public Property A1 As Integer
            Get
                Return a
            End Get
            Set(value As Integer)
                a = value
            End Set
        End Property
    End Class
    Class nnn
        Private Structure n1
            Private m As Integer
            Private n As Integer
        End Structure
    End Class
    Public Class Rng
        Private Shared rngp As Security.Cryptography.RNGCryptoServiceProvider = New Security.Cryptography.RNGCryptoServiceProvider()
        Private Shared rndSeries(8) As Byte
        Private Shared _base As Decimal = CDec(Long.MaxValue)
        ''' <summary>
        ''' 產生一個非負數且在最小值min和最大值 max之间的整数 包含最小值min  不包含最大值max  
        ''' </summary>
        ''' <param name="min">最小值</param>
        ''' <param name="max">最大值</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function RandomInt(ByVal min As Integer, ByVal max As Integer) As Integer
            rngp.GetBytes(rndSeries)
            Dim rand As Double = Math.Abs(BitConverter.ToInt64(rndSeries, 0)) / _base * (max - min) + min
            Return Math.Floor(rand)
        End Function
        ''' <summary>
        ''' 產生一個非負數且最大值 max 以下的小数  不包含最大值 不包含0
        ''' </summary>
        ''' <param name="max">最大值</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function RandomDouble(ByVal max As Double) As Double
            rngp.GetBytes(rndSeries)
            Dim rand As Double = Math.Abs(BitConverter.ToInt64(rndSeries, 0)) / _base * max
            Return rand
        End Function
    End Class
End Module
