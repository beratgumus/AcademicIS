namespace AcademicIS {
    public class FacDep {
        public int id;
        public string name;

        public FacDep(int id, string name) {
            this.id = id;
            this.name = name;
        }

        public FacDep() { }

        public override string ToString() {
            return name;
        }

        public override int GetHashCode() {
            if (name == null)
                return 0;

            return name.GetHashCode();
        }

        public override bool Equals(object obj) {
            if (obj == null)
                return false;
            
            if (obj.GetType().Name == "FacDep") {
                FacDep o = (FacDep)obj;
                return o.id == this.id && o.name == this.name;
            }
            else
                return false;
        }
    }
}
