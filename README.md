# MemoryLeak

!address -summary MEM_COMMIT 4.423 GB

```
0:000> !address -summary

--- Usage Summary ---------------- RgnCount ----------- Total Size -------- %ofBusy %ofTotal
Free                                    579     7df9`74541000 ( 125.974 TB)           98.42%
<unknown>                               912      206`7c9dc000 (   2.025 TB)  99.99%    1.58%
Image                                   972        0`06a01000 ( 106.004 MB)   0.00%    0.00%
Heap                                     81        0`05a27000 (  90.152 MB)   0.00%    0.00%
Stack                                   114        0`02a80000 (  42.500 MB)   0.00%    0.00%
Other                                     9        0`001de000 (   1.867 MB)   0.00%    0.00%
TEB                                      38        0`0004c000 ( 304.000 kB)   0.00%    0.00%
PEB                                       1        0`00001000 (   4.000 kB)   0.00%    0.00%

--- Type Summary (for busy) ------ RgnCount ----------- Total Size -------- %ofBusy %ofTotal
MEM_MAPPED                              220      200`062b0000 (   2.000 TB)  98.74%    1.56%
MEM_PRIVATE                             935        6`7edfe000 (  25.982 GB)   1.25%    0.02%
MEM_IMAGE                               972        0`06a01000 ( 106.004 MB)   0.00%    0.00%

--- State Summary ---------------- RgnCount ----------- Total Size -------- %ofBusy %ofTotal
MEM_FREE                                579     7df9`74541000 ( 125.974 TB)           98.42%
MEM_RESERVE                             296      205`709f6000 (   2.021 TB)  99.79%    1.58%
MEM_COMMIT                             1831        1`1b0b9000 (   4.423 GB)   0.21%    0.00%

--- Protect Summary (for commit) - RgnCount ----------- Total Size -------- %ofBusy %ofTotal
PAGE_READWRITE                          862        1`0e1cc000 (   4.221 GB)   0.20%    0.00%
PAGE_READONLY                           579        0`0659a000 ( 101.602 MB)   0.00%    0.00%
PAGE_EXECUTE_READ                       159        0`04f2b000 (  79.168 MB)   0.00%    0.00%
PAGE_NOACCESS                            80        0`01550000 (  21.312 MB)   0.00%    0.00%
PAGE_EXECUTE_READWRITE                   19        0`002ba000 (   2.727 MB)   0.00%    0.00%
PAGE_WRITECOPY                           94        0`001aa000 (   1.664 MB)   0.00%    0.00%
PAGE_READWRITE | PAGE_GUARD              38        0`00074000 ( 464.000 kB)   0.00%    0.00%

--- Largest Region by Usage ----------- Base Address -------- Region Size ----------
Free                                    21e`6c05c000     7bd5`f48f4000 ( 123.836 TB)
<unknown>                              7dfd`d8ac0000      1f7`68898000 (   1.966 TB)
Image                                  7ff9`71121000        0`009ba000 (   9.727 MB)
Heap                                    218`83c71000        0`00eff000 (  14.996 MB)
Stack                                    22`cad80000        0`0017c000 (   1.484 MB)
Other                                   218`f1b50000        0`00181000 (   1.504 MB)
TEB                                      22`ca410000        0`00002000 (   8.000 kB)
PEB                                      22`ca40f000        0`00001000 (   4.000 kB)
```


!eeheap -gc 405618688 bytes.

```
0:000> !eeheap -gc
Number of GC Heaps: 12
------------------------------
Heap 0 (00000218F3182A40)
generation 0 starts at 0x00000218F34C9DB0
generation 1 starts at 0x00000218F3477478
generation 2 starts at 0x00000218F3461000
ephemeral segment allocation context: none
         segment             begin         allocated         committed    allocated size    committed size
00000218F3460000  00000218F3461000  00000218F3A0BDC8  00000218F3F02000  0x5aadc8(5942728)  0xaa1000(11145216)
Large object heap starts at 0x0000021BF3461000
         segment             begin         allocated         committed    allocated size    committed size
0000021BF3460000  0000021BF3461000  0000021BF449E8D0  0000021BF44BF000  0x103d8d0(17029328)  0x105e000(17162240)
Pinned object heap starts at 0x0000021CB3461000
0000021CB3460000  0000021CB3461000  0000021CB3464FF0  0000021CB3472000  0x3ff0(16368)  0x11000(69632)
Allocated Heap Size:       Size: 0x15ec688 (22988424) bytes.
Committed Heap Size:       Size: 0x1aff000 (28307456) bytes.
------------------------------
Heap 1 (00000218F31AE470)
generation 0 starts at 0x00000219334C05F8
generation 1 starts at 0x0000021933471E28
generation 2 starts at 0x0000021933461000
ephemeral segment allocation context: none
         segment             begin         allocated         committed    allocated size    committed size
0000021933460000  0000021933461000  0000021933A20610  0000021933EE2000  0x5bf610(6026768)  0xa81000(11014144)
Large object heap starts at 0x0000021C03461000
         segment             begin         allocated         committed    allocated size    committed size
0000021C03460000  0000021C03461000  0000021C0451F4E8  0000021C04520000  0x10be4e8(17556712)  0x10bf000(17559552)
Pinned object heap starts at 0x0000021CC3461000
0000021CC3460000  0000021CC3461000  0000021CC3462030  0000021CC3472000  0x1030(4144)  0x11000(69632)
Allocated Heap Size:       Size: 0x167eb28 (23587624) bytes.
Committed Heap Size:       Size: 0x1b40000 (28573696) bytes.
------------------------------
Heap 2 (00000218F31DD200)
generation 0 starts at 0x00000219734967E0
generation 1 starts at 0x000002197346DFB0
generation 2 starts at 0x0000021973461000
ephemeral segment allocation context: none
         segment             begin         allocated         committed    allocated size    committed size
0000021973460000  0000021973461000  00000219734987F8  0000021973E52000  0x377f8(227320)  0x9f1000(10424320)
Large object heap starts at 0x0000021C13461000
         segment             begin         allocated         committed    allocated size    committed size
0000021C13460000  0000021C13461000  0000021C14B631F8  0000021C14B83000  0x17021f8(24125944)  0x1722000(24256512)
Pinned object heap starts at 0x0000021CD3461000
0000021CD3460000  0000021CD3461000  0000021CD3461018  0000021CD3462000  0x18(24)  0x1000(4096)
Allocated Heap Size:       Size: 0x1739a08 (24353288) bytes.
Committed Heap Size:       Size: 0x2113000 (34680832) bytes.
------------------------------
Heap 3 (00000218F3208F70)
generation 0 starts at 0x00000219B34B7828
generation 1 starts at 0x00000219B3489AB8
generation 2 starts at 0x00000219B3461000
ephemeral segment allocation context: none
         segment             begin         allocated         committed    allocated size    committed size
00000219B3460000  00000219B3461000  00000219B3A17840  00000219B3EC2000  0x5b6840(5990464)  0xa61000(10883072)
Large object heap starts at 0x0000021C23461000
         segment             begin         allocated         committed    allocated size    committed size
0000021C23460000  0000021C23461000  0000021C24B43768  0000021C24B83000  0x16e2768(23996264)  0x1722000(24256512)
Pinned object heap starts at 0x0000021CE3461000
0000021CE3460000  0000021CE3461000  0000021CE3462030  0000021CE3472000  0x1030(4144)  0x11000(69632)
Allocated Heap Size:       Size: 0x1c99fd8 (29990872) bytes.
Committed Heap Size:       Size: 0x2183000 (35139584) bytes.
------------------------------
Heap 4 (00000218F3234CE0)
generation 0 starts at 0x00000219F34DC428
generation 1 starts at 0x00000219F34730F0
generation 2 starts at 0x00000219F3461000
ephemeral segment allocation context: none
         segment             begin         allocated         committed    allocated size    committed size
00000219F3460000  00000219F3461000  00000219F3BAA440  00000219F3EE2000  0x749440(7640128)  0xa81000(11014144)
Large object heap starts at 0x0000021C33461000
         segment             begin         allocated         committed    allocated size    committed size
0000021C33460000  0000021C33461000  0000021C3410D580  0000021C3412E000  0xcac580(13288832)  0xccd000(13422592)
Pinned object heap starts at 0x0000021CF3461000
0000021CF3460000  0000021CF3461000  0000021CF3465030  0000021CF3472000  0x4030(16432)  0x11000(69632)
Allocated Heap Size:       Size: 0x13f99f0 (20945392) bytes.
Committed Heap Size:       Size: 0x174e000 (24436736) bytes.
------------------------------
Heap 5 (0000021D7EDD1EF0)
generation 0 starts at 0x0000021A334F9AF8
generation 1 starts at 0x0000021A33485C40
generation 2 starts at 0x0000021A33461000
ephemeral segment allocation context: none
         segment             begin         allocated         committed    allocated size    committed size
0000021A33460000  0000021A33461000  0000021A33A59B10  0000021A33F02000  0x5f8b10(6261520)  0xaa1000(11145216)
Large object heap starts at 0x0000021C43461000
         segment             begin         allocated         committed    allocated size    committed size
0000021C43460000  0000021C43461000  0000021C444BCE08  0000021C4451C000  0x105be08(17153544)  0x10bb000(17543168)
Pinned object heap starts at 0x0000021D03461000
0000021D03460000  0000021D03461000  0000021D03461018  0000021D03462000  0x18(24)  0x1000(4096)
Allocated Heap Size:       Size: 0x1654930 (23415088) bytes.
Committed Heap Size:       Size: 0x1b5c000 (28688384) bytes.
------------------------------
Heap 6 (0000021D7EDFD920)
generation 0 starts at 0x0000021A73495A38
generation 1 starts at 0x0000021A73469D68
generation 2 starts at 0x0000021A73461000
ephemeral segment allocation context: none
         segment             begin         allocated         committed    allocated size    committed size
0000021A73460000  0000021A73461000  0000021A73A15A50  0000021A73E92000  0x5b4a50(5982800)  0xa31000(10686464)
Large object heap starts at 0x0000021C53461000
         segment             begin         allocated         committed    allocated size    committed size
0000021C53460000  0000021C53461000  0000021C549CAFA8  0000021C549CB000  0x1569fa8(22454184)  0x156a000(22454272)
Pinned object heap starts at 0x0000021D13461000
0000021D13460000  0000021D13461000  0000021D13461018  0000021D13462000  0x18(24)  0x1000(4096)
Allocated Heap Size:       Size: 0x1b1ea10 (28437008) bytes.
Committed Heap Size:       Size: 0x1f9b000 (33140736) bytes.
------------------------------
Heap 7 (0000021D7EE29690)
generation 0 starts at 0x0000021AB35B3700
generation 1 starts at 0x0000021AB3580548
generation 2 starts at 0x0000021AB3461000
ephemeral segment allocation context: none
         segment             begin         allocated         committed    allocated size    committed size
0000021AB3460000  0000021AB3461000  0000021AB39D3718  0000021AB3FC2000  0x572718(5711640)  0xb61000(11931648)
Large object heap starts at 0x0000021C63461000
         segment             begin         allocated         committed    allocated size    committed size
0000021C63460000  0000021C63461000  0000021C649CCBF8  0000021C649ED000  0x156bbf8(22461432)  0x158c000(22593536)
Pinned object heap starts at 0x0000021D23461000
0000021D23460000  0000021D23461000  0000021D23461018  0000021D23462000  0x18(24)  0x1000(4096)
Allocated Heap Size:       Size: 0x1ade328 (28173096) bytes.
Committed Heap Size:       Size: 0x20ed000 (34525184) bytes.
------------------------------
Heap 8 (0000021D7EE55400)
generation 0 starts at 0x0000021AF3496810
generation 1 starts at 0x0000021AF3472A28
generation 2 starts at 0x0000021AF3461000
ephemeral segment allocation context: none
         segment             begin         allocated         committed    allocated size    committed size
0000021AF3460000  0000021AF3461000  0000021AF39F6828  0000021AF3E92000  0x595828(5855272)  0xa31000(10686464)
Large object heap starts at 0x0000021C73461000
         segment             begin         allocated         committed    allocated size    committed size
0000021C73460000  0000021C73461000  0000021C7492E5F8  0000021C7494F000  0x14cd5f8(21812728)  0x14ee000(21946368)
Pinned object heap starts at 0x0000021D33461000
0000021D33460000  0000021D33461000  0000021D33461830  0000021D33462000  0x830(2096)  0x1000(4096)
Allocated Heap Size:       Size: 0x1a63650 (27670096) bytes.
Committed Heap Size:       Size: 0x1f1f000 (32632832) bytes.
------------------------------
Heap 9 (0000021D7EE81170)
generation 0 starts at 0x0000021B334DE9E0
generation 1 starts at 0x0000021B334A73C8
generation 2 starts at 0x0000021B33461000
ephemeral segment allocation context: none
         segment             begin         allocated         committed    allocated size    committed size
0000021B33460000  0000021B33461000  0000021B33A409F8  0000021B33E82000  0x5df9f8(6158840)  0xa21000(10620928)
Large object heap starts at 0x0000021C83461000
         segment             begin         allocated         committed    allocated size    committed size
0000021C83460000  0000021C83461000  0000021C849E9DF8  0000021C84A0A000  0x1588df8(22580728)  0x15a9000(22712320)
Pinned object heap starts at 0x0000021D43461000
0000021D43460000  0000021D43461000  0000021D43461018  0000021D43462000  0x18(24)  0x1000(4096)
Allocated Heap Size:       Size: 0x1b68808 (28739592) bytes.
Committed Heap Size:       Size: 0x1fca000 (33333248) bytes.
------------------------------
Heap 10 (0000021D7EEADD80)
generation 0 starts at 0x0000021B73544EC8
generation 1 starts at 0x0000021B73504C18
generation 2 starts at 0x0000021B73461000
ephemeral segment allocation context: none
         segment             begin         allocated         committed    allocated size    committed size
0000021B73460000  0000021B73461000  0000021B73AEAEE0  0000021B73F42000  0x689ee0(6856416)  0xae1000(11407360)
Large object heap starts at 0x0000021C93461000
         segment             begin         allocated         committed    allocated size    committed size
0000021C93460000  0000021C93461000  0000021C955DEF78  0000021C955DF000  0x217df78(35118968)  0x217e000(35119104)
Pinned object heap starts at 0x0000021D53461000
0000021D53460000  0000021D53461000  0000021D53468450  0000021D53472000  0x7450(29776)  0x11000(69632)
Allocated Heap Size:       Size: 0x280f2a8 (42005160) bytes.
Committed Heap Size:       Size: 0x2c5f000 (46526464) bytes.
------------------------------
Heap 11 (0000021D7EED9980)
generation 0 starts at 0x0000021BB34C6550
generation 1 starts at 0x0000021BB34784A8
generation 2 starts at 0x0000021BB3461000
ephemeral segment allocation context: none
         segment             begin         allocated         committed    allocated size    committed size
0000021BB3460000  0000021BB3461000  0000021BB3906568  0000021BB3EA2000  0x4a5568(4871528)  0xa41000(10752000)
Large object heap starts at 0x0000021CA3461000
         segment             begin         allocated         committed    allocated size    committed size
0000021CA3460000  0000021CA3461000  0000021CA55A4DB8  0000021CA55A5000  0x2143db8(34880952)  0x2144000(34881536)
Pinned object heap starts at 0x0000021D63461000
0000021D63460000  0000021D63461000  0000021D6346CF88  0000021D63472000  0xbf88(49032)  0x11000(69632)
Allocated Heap Size:       Size: 0x25f52a8 (39801512) bytes.
Committed Heap Size:       Size: 0x2b85000 (45633536) bytes.
------------------------------
GC Allocated Heap Size:    Size: 0x14459f90 (340107152) bytes.
GC Committed Heap Size:    Size: 0x182d4000 (405618688) bytes.
```
!heap -s

```
0:000> !heap -s


************************************************************************************************************************
                                              NT HEAP STATS BELOW
************************************************************************************************************************
LFH Key                   : 0xa893144b6b979747
Termination on corruption : ENABLED
          Heap     Flags   Reserv  Commit  Virt   Free  List   UCR  Virt  Lock  Fast 
                            (k)     (k)    (k)     (k) length      blocks cont. heap 
-------------------------------------------------------------------------------------
00000218f1710000 00000002   65320  14712  64928   5575   163    16    2      c   LFH
    External fragmentation  38 % (163 free blocks)
00000218f1660000 00008000      64      4     64      2     1     1    0      0      
00000218f16f0000 00001002    3516   2388   3124    200    58     3    0      0   LFH
00000218f3360000 00001002      60      8     60      2     1     1    0      0      
00000218f3450000 00041002      60      8     60      5     1     1    0      0      
0000021d7fa40000 00001002    3516   1460   3124     89    25     3    0      0   LFH
0000021d7fc00000 00001002      60      8     60      5     1     1    0      0      
0000021d7fbc0000 00001002     452     32     60      5     2     1    0      0   LFH
-------------------------------------------------------------------------------------

```
