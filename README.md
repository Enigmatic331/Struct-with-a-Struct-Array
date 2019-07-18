# Struct with a Struct Array
 Test case for struct aray within a struct

Test cases to test Nethereum's decoding of a struct which has a nested struct (and possibly other accompanying data).

Consist of three test cases:

1. Struct with struct[], uint256
2. Struct with uint256, struct[]
3. Struct with struct[], struct[], uint256

To debug, simply set a break point on the test cases and review the getResult variable.

![Example](https://pictr.com/images/2019/07/18/5HXDFY.png)

The amended ParameterDecode (Nethereum.ABI DLL) is bundled under the debug folder, and source codes could be found at \Updated ParameterDecoder\ParameterDecoder.cs. If replaced with the original Nethereum.ABI, then the problem as described (infinite loop, or wrongly returned data) will occur.
