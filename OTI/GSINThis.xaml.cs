﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace OTI
{
    /// <summary>
    /// Логика взаимодействия для GSINThis.xaml
    /// </summary>
    public partial class GSINThis : Window
    {
        public GSINThis()
        {
            InitializeComponent();
        }

        private void al_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("заранее заданная последовательность четко определенных правил или команд для получения решения задачи (например,путем выполнения некоторой вычислительной процедуры) за конечное число шагов.", "Алгоритм");
        }

        private void BK_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" код с обнаружением или исправлением ошибок, в котором за одну операцию на вход кодера поступает фиксированное число (например,k) знаков,а на выходе генерируется кодовое cлово,состоящее из большего числа знаков (например, n). Соответственно декодер принимает n знаков и выдает k знаков. Этот код иногда называют (n,k)-кодом, т.е. с длиной блока k и длиной кодового слова - n.Поскольку кодовые слова длиннее входных слов,число одновременно принимаемых слов не так велико.", "Блочный код");
        }

        private void BOD_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("единица измерения скорости передачи информации; представляет собой число изменений состояния системы, в частности канала передачи данных,в секунду.В случае двоичного канала скорость передачи в бодах равна скорости передачи битов, т.е. 1 бод = 1 бит / с.В более общем случае 1 бод = 1 знак / с или1 бод = 1 символ / с.В зависимости от способа представления состояний системы боды могут измеряться и по - другому.Единица измерения 1 бод 0 названа в честь французского изобретателя телеграфного аппарата  Ж.М.Э.Бодо.", "БОД");
        }

        private void VP_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("мера соответствия принятого сигнала (сообщения) переданному сигналу (сообщению).", "Вероятность передачи");
        }

        private void V_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("число между 0 и 1, ассоциируемое с событием, которое является одним из множества возможных; событие, которое обязательно происходит, имеет вероятность 1. Вероятность события имеет   ограниченную величину, определяемую относительной частотой события при неограниченном увеличении числа наблюдений. Кроме того, это число характеризует степень уверенности в том, что событие обязательно произойдет.", "Вероятность");
        }

        private void GK_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" пределы производительности кода, выраженные такими параметрами,как число кодовых слов, минимальное расстояние Хемминга, длина кодового слова и эффективность. Применяются в общем и частных случаях к кодам с обнаружением и исправлением ошибок   и задаются в виде разнообразных неравенств. Среди многих известных границ кодирования наиболее важными являются граница Хемминга и граница Варшамова - Гильберта.", "Граница кодирования");
        }

        private void DE_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("устройство, преобразующее входные аналоговые сигналы в выходные цифровые. Принцип действия демодулятора обратен принципу действия модулятора, в котором цифровые сигналы преобразуются в аналоговые.", "Демодулятор");
        }

        private void DK_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("в кодере это число генерируемых в процессе операции кодирования символов. Обычно число вводимых в кодер символов фиксировано; число выводимых символов может быть либо фиксированным, либо переменным, в зависимости от типа используемого коде, который может формировать код фиксированной или переменной длины.", "Длина кода");
        }

        private void INT_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" языковый процессор, который построчно анализирует исходную программу и одновременно выполняет предписанные действия, а не формирует на машинном языке скомпилированную программу, которая выполняется впоследствии.", "Интерпритатор");
        }

        private void INSY_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("автоматизированная система, определяющей особенностью которой является то, что она обеспечивает информацией пользователей из нескольких организаций. Именно этимона отличается, например, от управляющей системы реального времени, системы коммутации сообщений, среды программирования или персональной вычислительной системы. Рассматривая диапазон возможных значений слов 'информация' и 'система', можно предложить ряд более широких толкований термина 'информационная система'. Можно считать, например, что он относится ко всем автоматизированным системам или, в еще более широком смысле, ко многим системам, в состав которых не входят ЭВМ. Поэтому при рассмотрении только автоматизированных систем иногда употребляют термин информационная система организационного типа .         Информационные системы предназначены для решения задач обработки данных, автоматизации конторских работ, а также задач, характерных для экспертных систем. Системы, основной функцией которых является информационное обеспечение процесса управления, обычно называют управленческими информационными системами.", "Информационная система");
        }

        private void ISC_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("нежелательные изменения формы сигнала, возникающие между двумя точками в системах передачи. Существует пять следующих основных типов искажения : искажения, вносимое характеристика ми; искажение задержки; искажение от стартстопных сигналов стохастическое искажение; нелинейное искажение.", "Искажение");
        }

        private void KPD_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("путь передачи информации со всеми необходимыми схемами, который используется для пересылки данных между системами или частями системы. В случае интерфейса, состоящего из нескольких параллельных каналов, каждый канал выделяется для передачи информации одного типа, например, данных или сигналов управления.", "Канал передачи данных");
        }

        private void DST_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("множество дискретных элементов, на котором определен некоторый набор операций. Термин 'дискретный' означает отсутствие непрерывности, поэтому к дискретным множествам следует относить конечные множества и счетные множества, в то же время несчетные множества, такие как множество действительных чисел, не являются дискретными.", "Дискретная структура");
        }

        private void PAM_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("устройство или среда, которая может сохранять информацию для последующего ее извлечения.", "Память");
        }

        private void INF_Copy_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("количественная или качественная оценка информации в сообщении. Mера Хартли - аддитивная двоичная логарифмическая мера, позволяющая вычислять количество информации в двоичных единицах(бит).", "Мера информации");
        }

        private void PPD_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" набор правил и соглашений, определяющих форматы данных и процедуры передачи для обмена информацией между взаимодействующими процессами, функциональными или логическими модулями, абонентскими станциями и т.д. Распаковка - процесс преобразования информации из упакованного формата в форму, при которой можно получить непосредственный  доступ к отдельным элементам данных.", "Протокол передачи данных");
        }
    }
}
