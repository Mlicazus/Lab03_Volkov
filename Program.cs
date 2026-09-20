// Console.WriteLine("Банковский счёт");
// double balance = 1000;
// Console.WriteLine($"Начальный баланс: {balance}");
// balance += 500;
// Console.WriteLine($"После пополнения на 500: {balance}");
// balance -= 200;
// Console.WriteLine($"После покупки на 200: {balance}");
// balance *= 1.05;
// Console.WriteLine($"После начисления 5%: {balance}");
// balance /= 2;
// Console.WriteLine($"После деления пополам: {balance}");

// Console.WriteLine();
// Console.WriteLine("Постфикс vs префикс");
// int lessonNumber = 1;
// Console.WriteLine($"++lessonNumber выводит: {lessonNumber++}");
// Console.WriteLine($"После этого lessonNumber = {lessonNumber}");
// int weekNumber = 1;
// Console.WriteLine($"++weekNumber выводит: {++weekNumber}");
// Console.WriteLine($"После этого lessonNumber = {weekNumber}");
// Console.WriteLine();
// Console.WriteLine("Практическая ловушка");
// int attempts = 0;
// Console.WriteLine($"Попытка №{++attempts}");
// Console.WriteLine($"Попытка №{++attempts}");
// Console.WriteLine($"Всего попыток: {attempts}");

// Console.WriteLine();
// Console.WriteLine("Операторы сравнения");
// double myGrade = 4.6;
// double passingGrade = 4.0;
// int myAge = 20;
// int votingAge = 18;
// bool isPassing = myGrade >= passingGrade;
// bool isExactAge = myAge == votingAge;
// bool canVote = myAge >= votingAge;
// bool isNotFailing = myGrade != 2.0;
// Console.WriteLine($"Балл {myGrade} >= {passingGrade}: {isPassing}");
// Console.WriteLine($"Возраст {myAge} == {votingAge}: {isExactAge}");
// Console.WriteLine($"Возраст {myAge} >= {votingAge} (может голосовать): {canVote}");
// Console.WriteLine($"Балл {myGrade} != 2.0 (не двойка): {isNotFailing}");

// Console.WriteLine();
// Console.WriteLine("Логические операторы");
// bool hasPassingGrade = true;
// bool hasAttendance = false;
// bool hasDebt = true;
// bool canGetScholarship = hasPassingGrade && hasAttendance;
// bool canRetakeExam = hasPassingGrade || hasAttendance;
// bool isDebtFree = !hasDebt;
// Console.WriteLine($"Может получить стипендию (оценка И посещаемость): {canGetScholarship}");
// Console.WriteLine($"Может пересдать (оценка ИЛИ посещаемость): {canRetakeExam}");
// Console.WriteLine($"Нет долгов: {isDebtFree}");

// using System.ComponentModel.DataAnnotations;

// Console.WriteLine();
// Console.WriteLine("Короткое замыкание");
// bool CheckAndPrint(string label, bool value)
// {
//     Console.WriteLine($"    Вычисляется: {label}");
//     return value;
// }
// Console.WriteLine("Проверяем && (первый операнд false):");
// bool resultAnd = CheckAndPrint("A", false) && CheckAndPrint("B", true);
// Console.WriteLine($"Результат: {resultAnd}");
// Console.WriteLine();
// Console.WriteLine("Проверяем || (первый операнд true):");
// bool resultOr = CheckAndPrint("C", true) || CheckAndPrint("D", false);
// Console.WriteLine($"Результат: {resultOr}");

// Console.WriteLine();
// Console.WriteLine("Приоритет операций");
// int resultNoParens = 2 + 3 * 4;
// int resultWithParens = (2 + 3) * 4;
// Console.WriteLine($"2 + 3 * 4       = {resultNoParens}");
// Console.WriteLine($"(2 + 3) * 4     = {resultWithParens}");
// bool logicResult = 5 > 3 && 2 < 4 || false;
// bool logicResultParens = (5 > 3 && 2 < 4) || false;
// Console.WriteLine($"5 > 3 && 2 < 4 || false    = {logicResult}");
// Console.WriteLine($"(5 > 3 && 2 < 4) || false  = {logicResultParens}");

// Console.WriteLine();
// Console.WriteLine("Приёмная комиссия");
// Console.Write("Введите средний балл аттестата: ");
// double averageGrade = double.Parse(Console.ReadLine());
// Console.Write("Введите баллы за экзамен (0-100): ");
// int examScore = int.Parse(Console.ReadLine());
// Console.Write("Есть льгота? (1 - да, 0 - нет): ");
// int benefitInput = int.Parse(Console.ReadLine());
// bool hasBenefit = (benefitInput == 1);
// bool hasGoodCertificate = averageGrade >= 4.0;
// bool hasGoodExam = examScore >= 60;
// bool isEligibleByRules = (hasGoodCertificate && hasGoodExam) || hasBenefit;
// double totalScore = averageGrade * 10;
// totalScore += examScore;
// Console.WriteLine();
// Console.WriteLine($"Результат");
// Console.WriteLine($"Хороший аттестат (>= 4.0): {hasGoodCertificate}");
// Console.WriteLine($"Хороший экзамен (>= 60): {hasGoodExam}");
// Console.WriteLine($"Льгота: {hasBenefit}");
// Console.WriteLine($"Проходит по правилам: {isEligibleByRules}");
// Console.WriteLine($"Итоговый балл: {totalScore}");

// using System.Runtime.InteropServices;

// System.Console.Write("Введите целое число: ");
// int Integer = int.Parse(System.Console.ReadLine());
// bool isEven = Integer % 2 == 0;
// System.Console.WriteLine($"Число {Integer} четное: {isEven}");

// System.Console.WriteLine("Постфикс");
// int lessonNumber = 5;
// System.Console.WriteLine($"Изначально значение lessonNumber = {lessonNumber}. Значение lessonNumber++ равное {lessonNumber++} после постфикса изменяется в {lessonNumber}");
// System.Console.WriteLine("Префикс");
// int weekNumber = 10;
// System.Console.WriteLine($"Изначально значение weekNumber = {weekNumber}. Значение ++weekNumber равное {++weekNumber} после префикса изменяется в {weekNumber}");
// System.Console.WriteLine($"lessonNumber++ + ++weekNumber = {lessonNumber++ + ++weekNumber}");
// System.Console.WriteLine($"lessonNumber + weekNumber = {lessonNumber + weekNumber}");

System.Console.Write($"Сумма покупки: ");
double purchaseАmount = double.Parse(System.Console.ReadLine());
System.Console.Write($"Есть ли карта постоянного клиента (1 - да, 0 - нет): ");
bool isCard = int.Parse(System.Console.ReadLine()) == 1;
System.Console.Write($"Количество товаров в чеке: ");
int quantityGoods = int.Parse(System.Console.ReadLine());
bool eligibleForDiscount = purchaseАmount >= 3000 && quantityGoods >= 3 || isCard;
System.Console.WriteLine($"Итоговый результат: {eligibleForDiscount}");
System.Console.WriteLine($"Как получилось: \n1. {purchaseАmount >= 3000} И {quantityGoods >= 3} = {purchaseАmount >= 3000 && quantityGoods >= 3} \n2. {purchaseАmount >= 3000 && quantityGoods >= 3} ИЛИ {isCard} = {eligibleForDiscount}");
