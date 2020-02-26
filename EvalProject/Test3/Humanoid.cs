using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    public class Humanoid
    {
        private ISkill _skill;
        public Humanoid(ISkill skill)
        {
            _skill = skill;
        }

        public Humanoid()
        {
        }

        public string ShowSkill()
        {
            if (_skill != null)
                return _skill.ShowSkill();
            else
                return "No skill is defined";
        }
    }
}
