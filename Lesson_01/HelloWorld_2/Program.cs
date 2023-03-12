
// 1 byte = 8 bits
bool isCorrect = true;
bool isNotCorrect = false;

// 1 byte = 8 bits
byte upTo255 = 255;

// 2 bytes = 16 bits
short upTo32K = 32_767;
ushort upTo64K = 65_535;

// 4 bytes = 32 bits
// from -2,147,483,648 to 2,147,483,647
int upTo2B = 2_147_483_647;
uint upTo4B = 4_294_967_295;

// 8 bytes = 64 bits
long upTo9Q = 9_223_372_036_854_775_807;

// 4 bytes = 32 bits
// from -3.402823e38 to 3.402823e38
float upTo9Q_2 = 9_223_372_036_854_775_807;

// 8 bytes = 64 bits
// from -1.7976931348623157E+308 to 1.7976931348623157E+308
double upToX = 1.7976931348623157E+308;

// 24 bytes = 192 bits
// from -7.9228162514264337593543950335E+28 to 7.9228162514264337593543950335E+28
decimal upToY = 7.9228162514264337593543950335E+28m;

// each character is 2 bytes
string name = "John";

// arithmetic operators
int a = 10;
int b = 5;
int c = a + b; // 15
int d = a - b; // 5
int e = a * b; // 50
int f = a / b; // 2
int g = a % b; // 0


string firstName = "John";
string lastName = "Doe";

string fullName = firstName + " " + lastName; // "John Doe"

// brackets
int a1 = 10;
int b1 = 5;
int c1 = a1 + b1 * 2; // 20
int d1 = (a1 + b1) * 2; // 30

int a2 = 3;
int b2 = 2;
float c2 = (float)a2 / b2; // 1

Console.WriteLine(c2);