## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
```assembly
; Bdn1.ListsBenchmark4.Sum_ByIndex()
                   int sum = 0;
                   ^^^^^^^^^^^^
       IL_0000: ldc.i4.0
       IL_0001: stloc.0
       xor     eax,eax
                   for (int i = 0; i < _data.Length; ++i)
                        ^^^^^^^^^
       IL_0002: ldc.i4.0
       IL_0003: stloc.1
       IL_0004: br.s IL_0015
       xor     edx,edx
                   for (int i = 0; i < _data.Length; ++i)
                                   ^^^^^^^^^^^^^^^^
       IL_0015: ldloc.1
       IL_0016: ldarg.0
       IL_0017: ldfld System.Byte[] Bdn1.ListsBenchmark4::_data
       IL_001c: ldlen
       IL_001d: conv.i4
       IL_001e: blt.s IL_0006
       mov     rcx,qword ptr [rcx+8]
       mov     r8d,dword ptr [rcx+8]
       test    r8d,r8d
       jle     M00_L01
                       sum += _data[i];
                       ^^^^^^^^^^^^^^^^
       IL_0006: ldloc.0
       IL_0007: ldarg.0
       IL_0008: ldfld System.Byte[] Bdn1.ListsBenchmark4::_data
       IL_000d: ldloc.1
       IL_000e: ldelem.u1
       IL_000f: add
       IL_0010: stloc.0
M00_L00:
       mov     r9,rcx
       movsxd  r10,edx
       movzx   r9d,byte ptr [r9+r10+10h]
       add     eax,r9d
                   for (int i = 0; i < _data.Length; ++i)
                                                     ^^^
       IL_0011: ldloc.1
       IL_0012: ldc.i4.1
       IL_0013: add
       IL_0014: stloc.1
       inc     edx
       cmp     r8d,edx
       jg      M00_L00
                   return sum;
                   ^^^^^^^^^^^
       IL_0020: ldloc.0
       IL_0021: ret
M00_L01:
       ret
; Total bytes of code 40
```

## .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
```assembly
; Bdn1.ListsBenchmark4.Sum_Foreach()
                   int sum = 0;
                   ^^^^^^^^^^^^
       IL_0000: ldc.i4.0
       IL_0001: stloc.0
       xor     eax,eax
                   foreach (var n in _data)
                                     ^^^^^
       IL_0002: ldarg.0
       IL_0003: ldfld System.Byte[] Bdn1.ListsBenchmark4::_data
       IL_0008: stloc.1
       mov     rdx,qword ptr [rcx+8]
       IL_0009: ldc.i4.0
       IL_000a: stloc.2
       IL_000b: br.s IL_0019
       xor     ecx,ecx
                   foreach (var n in _data)
                                  ^^
       IL_0019: ldloc.2
       IL_001a: ldloc.1
       IL_001b: ldlen
       IL_001c: conv.i4
       IL_001d: blt.s IL_000d
       mov     r8d,dword ptr [rdx+8]
       test    r8d,r8d
       jle     M00_L01
                   foreach (var n in _data)
                            ^^^^^
       IL_000d: ldloc.1
       IL_000e: ldloc.2
       IL_000f: ldelem.u1
       IL_0010: stloc.3
M00_L00:
       movsxd  r9,ecx
       movzx   r9d,byte ptr [rdx+r9+10h]
                       sum += n;
                       ^^^^^^^^^
       IL_0011: ldloc.0
       IL_0012: ldloc.3
       IL_0013: add
       IL_0014: stloc.0
       add     eax,r9d
       IL_0015: ldloc.2
       IL_0016: ldc.i4.1
       IL_0017: add
       IL_0018: stloc.2
       inc     ecx
       cmp     r8d,ecx
       jg      M00_L00
                   return sum;
                   ^^^^^^^^^^^
       IL_001f: ldloc.0
       IL_0020: ret
M00_L01:
       ret
; Total bytes of code 37
```

## .NET Core 2.2.3 (CoreCLR 4.6.27414.05, CoreFX 4.6.27414.05), 64bit RyuJIT
```assembly
; Bdn1.ListsBenchmark4.Sum_ByIndex()
                   int sum = 0;
                   ^^^^^^^^^^^^
       IL_0000: ldc.i4.0
       IL_0001: stloc.0
       xor     eax,eax
       mov     dword ptr [rbp-4],eax
                   for (int i = 0; i < _data.Length; ++i)
                        ^^^^^^^^^
       IL_0002: ldc.i4.0
       IL_0003: stloc.1
       IL_0004: br.s IL_0015
       mov     dword ptr [rbp-8],eax
       jmp     M00_L01
                       sum += _data[i];
                       ^^^^^^^^^^^^^^^^
       IL_0006: ldloc.0
       IL_0007: ldarg.0
       IL_0008: ldfld System.Byte[] Bdn1.ListsBenchmark4::_data
       IL_000d: ldloc.1
       IL_000e: ldelem.u1
       IL_000f: add
       IL_0010: stloc.0
M00_L00:
       mov     rax,qword ptr [rbp+10h]
       mov     rax,qword ptr [rax+8]
       mov     edx,dword ptr [rbp-8]
       cmp     rdx,qword ptr [rax+8]
       jae     00007ffe`fb12c6c0
       lea     rax,[rax+rdx+10h]
       movzx   eax,byte ptr [rax]
       add     eax,dword ptr [rbp-4]
       mov     dword ptr [rbp-4],eax
                   for (int i = 0; i < _data.Length; ++i)
                                                     ^^^
       IL_0011: ldloc.1
       IL_0012: ldc.i4.1
       IL_0013: add
       IL_0014: stloc.1
       mov     eax,dword ptr [rbp-8]
       inc     eax
       mov     dword ptr [rbp-8],eax
                   for (int i = 0; i < _data.Length; ++i)
                                   ^^^^^^^^^^^^^^^^
       IL_0015: ldloc.1
       IL_0016: ldarg.0
       IL_0017: ldfld System.Byte[] Bdn1.ListsBenchmark4::_data
       IL_001c: ldlen
       IL_001d: conv.i4
       IL_001e: blt.s IL_0006
M00_L01:
       mov     eax,dword ptr [rbp-8]
       mov     rdx,qword ptr [rbp+10h]
       mov     rdx,qword ptr [rdx+8]
       cmp     eax,dword ptr [rdx+8]
       jl      M00_L00
                   return sum;
                   ^^^^^^^^^^^
       IL_0020: ldloc.0
       IL_0021: ret
       mov     eax,dword ptr [rbp-4]
; Total bytes of code 68
```

## .NET Core 2.2.3 (CoreCLR 4.6.27414.05, CoreFX 4.6.27414.05), 64bit RyuJIT
```assembly
; Bdn1.ListsBenchmark4.Sum_Foreach()
                   int sum = 0;
                   ^^^^^^^^^^^^
       IL_0000: ldc.i4.0
       IL_0001: stloc.0
       xor     eax,eax
       mov     dword ptr [rbp-14h],eax
                   foreach (var n in _data)
                                     ^^^^^
       IL_0002: ldarg.0
       IL_0003: ldfld System.Byte[] Bdn1.ListsBenchmark4::_data
       IL_0008: stloc.1
       mov     rax,qword ptr [rbp+10h]
       mov     rax,qword ptr [rax+8]
       mov     qword ptr [rbp-20h],rax
       IL_0009: ldc.i4.0
       IL_000a: stloc.2
       IL_000b: br.s IL_0019
       xor     eax,eax
       mov     dword ptr [rbp-24h],eax
       jmp     M00_L01
                   foreach (var n in _data)
                            ^^^^^
       IL_000d: ldloc.1
       IL_000e: ldloc.2
       IL_000f: ldelem.u1
       IL_0010: stloc.3
M00_L00:
       mov     rax,qword ptr [rbp-20h]
       mov     edx,dword ptr [rbp-24h]
       cmp     rdx,qword ptr [rax+8]
       jae     00007ffe`fb13c6db
       lea     rax,[rax+rdx+10h]
       movzx   eax,byte ptr [rax]
       mov     dword ptr [rbp-28h],eax
                       sum += n;
                       ^^^^^^^^^
       IL_0011: ldloc.0
       IL_0012: ldloc.3
       IL_0013: add
       IL_0014: stloc.0
       mov     eax,dword ptr [rbp-14h]
       add     eax,dword ptr [rbp-28h]
       mov     dword ptr [rbp-14h],eax
       IL_0015: ldloc.2
       IL_0016: ldc.i4.1
       IL_0017: add
       IL_0018: stloc.2
       mov     eax,dword ptr [rbp-24h]
       inc     eax
       mov     dword ptr [rbp-24h],eax
                   foreach (var n in _data)
                                  ^^
       IL_0019: ldloc.2
       IL_001a: ldloc.1
       IL_001b: ldlen
       IL_001c: conv.i4
       IL_001d: blt.s IL_000d
M00_L01:
       mov     eax,dword ptr [rbp-24h]
       mov     rdx,qword ptr [rbp-20h]
       cmp     eax,dword ptr [rdx+8]
       jl      M00_L00
                   return sum;
                   ^^^^^^^^^^^
       IL_001f: ldloc.0
       IL_0020: ret
       mov     eax,dword ptr [rbp-14h]
; Total bytes of code 80
```

## .NET Core 3.0.0-preview7-27912-14 (CoreCLR 4.700.19.32702, CoreFX 4.700.19.36209), 64bit RyuJIT
```assembly
; Bdn1.ListsBenchmark4.Sum_ByIndex()
                   int sum = 0;
                   ^^^^^^^^^^^^
       IL_0000: ldc.i4.0
       IL_0001: stloc.0
       xor     eax,eax
                   for (int i = 0; i < _data.Length; ++i)
                        ^^^^^^^^^
       IL_0002: ldc.i4.0
       IL_0003: stloc.1
       IL_0004: br.s IL_0015
       xor     edx,edx
                   for (int i = 0; i < _data.Length; ++i)
                                   ^^^^^^^^^^^^^^^^
       IL_0015: ldloc.1
       IL_0016: ldarg.0
       IL_0017: ldfld System.Byte[] Bdn1.ListsBenchmark4::_data
       IL_001c: ldlen
       IL_001d: conv.i4
       IL_001e: blt.s IL_0006
       mov     rcx,qword ptr [rcx+8]
       cmp     dword ptr [rcx+8],0
       jle     M00_L01
                       sum += _data[i];
                       ^^^^^^^^^^^^^^^^
       IL_0006: ldloc.0
       IL_0007: ldarg.0
       IL_0008: ldfld System.Byte[] Bdn1.ListsBenchmark4::_data
       IL_000d: ldloc.1
       IL_000e: ldelem.u1
       IL_000f: add
       IL_0010: stloc.0
M00_L00:
       mov     r8,rcx
       cmp     edx,dword ptr [r8+8]
       jae     00007fff`04a18bb3
       movsxd  r9,edx
       movzx   r8d,byte ptr [r8+r9+10h]
       add     eax,r8d
                   for (int i = 0; i < _data.Length; ++i)
                                                     ^^^
       IL_0011: ldloc.1
       IL_0012: ldc.i4.1
       IL_0013: add
       IL_0014: stloc.1
       inc     edx
       cmp     dword ptr [rcx+8],edx
       jg      M00_L00
                   return sum;
                   ^^^^^^^^^^^
       IL_0020: ldloc.0
       IL_0021: ret
M00_L01:
       add     rsp,28h
; Total bytes of code 46
```

## .NET Core 3.0.0-preview7-27912-14 (CoreCLR 4.700.19.32702, CoreFX 4.700.19.36209), 64bit RyuJIT
```assembly
; Bdn1.ListsBenchmark4.Sum_Foreach()
                   int sum = 0;
                   ^^^^^^^^^^^^
       IL_0000: ldc.i4.0
       IL_0001: stloc.0
       xor     eax,eax
                   foreach (var n in _data)
                                     ^^^^^
       IL_0002: ldarg.0
       IL_0003: ldfld System.Byte[] Bdn1.ListsBenchmark4::_data
       IL_0008: stloc.1
       mov     rdx,qword ptr [rcx+8]
       IL_0009: ldc.i4.0
       IL_000a: stloc.2
       IL_000b: br.s IL_0019
       xor     ecx,ecx
                   foreach (var n in _data)
                                  ^^
       IL_0019: ldloc.2
       IL_001a: ldloc.1
       IL_001b: ldlen
       IL_001c: conv.i4
       IL_001d: blt.s IL_000d
       mov     r8d,dword ptr [rdx+8]
       test    r8d,r8d
       jle     M00_L01
                   foreach (var n in _data)
                            ^^^^^
       IL_000d: ldloc.1
       IL_000e: ldloc.2
       IL_000f: ldelem.u1
       IL_0010: stloc.3
M00_L00:
       movsxd  r9,ecx
       movzx   r9d,byte ptr [rdx+r9+10h]
                       sum += n;
                       ^^^^^^^^^
       IL_0011: ldloc.0
       IL_0012: ldloc.3
       IL_0013: add
       IL_0014: stloc.0
       add     eax,r9d
       IL_0015: ldloc.2
       IL_0016: ldc.i4.1
       IL_0017: add
       IL_0018: stloc.2
       inc     ecx
       cmp     r8d,ecx
       jg      M00_L00
                   return sum;
                   ^^^^^^^^^^^
       IL_001f: ldloc.0
       IL_0020: ret
M00_L01:
       ret
; Total bytes of code 37
```

