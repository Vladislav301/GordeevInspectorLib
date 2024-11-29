using System;
using System.Collections.Generic;

namespace InspectorLib
{
    public class FunctionInsp
    {
        private string _carInspectionName;
        private string _inspectorFullName;
        private List<string> _workers;

        public FunctionInsp() : this("Автоинспекция г. Чита", "Васильев Василий Иванович") { }

        public FunctionInsp(string carInspectionName, string inspectorFullName)
        {
            _carInspectionName = carInspectionName;
            _inspectorFullName = inspectorFullName;
            _workers = new List<string> { "Иванов И.И.", "Зиронов Т.А.", "Миронов А.В.", "Васильев В.И." };
        }

        public string GetInspector() => _inspectorFullName;

        public string GetCarInspection() => _carInspectionName;

        public bool SetInspector(string fullName)
        {
            if (_workers.Contains(fullName))
            {
                _inspectorFullName = fullName;
                return true;
            }
            return false;
        }

        public string GenerateNumber(char symbol, int code = 75)
        {
            Random random = new Random();
            int number = random.Next(1000, 10000);
            return $"{symbol.ToString().ToUpper()}{number}_{code}";
        }

        public List<string> GetWorkers() => _workers;

        public bool AddWorker(string fullName)
        {
            if (!_workers.Contains(fullName))
            {
                _workers.Add(fullName);
                return true;
            }
            return false;
        }

        public bool RemoveWorker(string fullName)
        {
            return _workers.Remove(fullName);
        }
    }
}
