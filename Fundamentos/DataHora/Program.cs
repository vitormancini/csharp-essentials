// Obtem data e hora atuais
DateTime dataAtual = DateTime.Now; // 11/1/2023 1:01:40 AM

// Cria data específica (aaaa, mm, dd)
DateTime dataEspecifica = new DateTime(1994, 09, 12);

// Cria data e hora específica (aaaa, mm, dd, h, m, s)
DateTime dataHoraEspecifica = new DateTime(1994, 09, 12, 8, 45, 32);

// Obtem dia, mês, ano, hora, minutos, segundos e milisegundos
int dia = dataAtual.Day;
int mes = dataAtual.Month;
int ano = dataAtual.Year;
int hora = dataAtual.Hour;
int minuto = dataAtual.Minute;
int segundos = dataAtual.Second;
int milisegundos = dataAtual.Millisecond;

// Adiciona valores
dataAtual.AddDays(20); // dias
dataAtual.AddMonths(2); // Meses
dataAtual.AddHours(3); // Horas
dataAtual.AddYears(5); // Anos

// Dia da semana por extenso
var diaSemana = dataAtual.DayOfWeek;
var diaAno = dataAtual.DayOfYear;

// Formato longo
dataAtual.ToLongDateString(); // terça-feira, 1 den ovembro de 2023

// Formato curto
dataAtual.ToShortDateString(); // 01/11/2023