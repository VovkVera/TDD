#include "pch.h"
#include <iostream>
// simple test example

#include <gtest/gtest.h>
struct  BankAccount
{
<<<<<<< HEAD
	int balance=0;
	
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
