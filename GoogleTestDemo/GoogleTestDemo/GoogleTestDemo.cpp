#include "pch.h"
#include <iostream>
// simple test example

#include <gtest/gtest.h>
struct  BankAccount
{
<<<<<<< HEAD
	int balance=0;
=======
	int balance = 0;
>>>>>>> 1afa2df0e16be6e2d8a56be3b4edb82817edf87c
	BankAccount()
	{
	}

	explicit BankAccount(const int balance)
		:balance{ balance }
	{

	}
};

TEST(AccountTest, BankAccountStartsEmpty)
{
	BankAccount account;
	EXPECT_EQ(0, account.balance);

}
int main(int argc, char* argv[])
{

	std::cout << "Hello World!\n";
	testing::InitGoogleTest(&argc, argv);
}
