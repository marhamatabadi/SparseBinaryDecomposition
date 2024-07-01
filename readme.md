## Problem Description

A non-negative integer N is called sparse if its binary representation does not contain two consecutive bits set to 1. For example:

-   41 is sparse (binary: "101001")
-   26 is not sparse (binary: "11010")

The challenge is to find two non-negative integers P and Q such that:

-   P and Q are sparse.
-   N=P+Q.

### Example:

For N=26:

-   Possible decompositions include:
    -   8 (binary: "1000") and 18 (binary: "10010")
    -   9 (binary: "1001") and 17 (binary: "10001")

## Solution

This project implements an efficient algorithm in C# to find one part of the sparse decomposition of N or returns −1 if no such decomposition exists. 
**The algorithm runs in constant time O(1).**

### Function Signature

    public static int Solution(int N)
    {
        if (IsSparse(N & 0x55555555))
            return N & 0x55555555;
        else if (IsSparse(N & 0xAAAAAAA))
            return (N & 0xAAAAAAA);
        else
            return -1;
    }
    private static bool IsSparse(int x)
    {
        return (x & (x >> 1)) == 0;
    }

## Getting Started

### Prerequisites

-   .NET Core SDK (Net8.0)
-   Integrated Development Environment (IDE) like Visual Studio or Visual Studio Code

### Installation

1.  Clone the repository:
2. Compile and run the project using your preferred IDE or command line tools.
## Usage

To use the solution, instantiate the `Main` class and call the `Solution` method with the desired integer N:

## Contributing

Contributions are welcome! If you have suggestions for improvements or new features, feel free to create an issue or submit a pull request. Please ensure your code follows the project's coding standards and includes appropriate tests.

## License

This project is licensed under the MIT License - see the LICENSE file for details.

## Acknowledgments

-   Thanks to the open-source community for their valuable contributions and resources.
-   Special thanks to everyone who has supported and contributed to this project.

[Linkedin](https://www.linkedin.com/in/marhamatabadi)