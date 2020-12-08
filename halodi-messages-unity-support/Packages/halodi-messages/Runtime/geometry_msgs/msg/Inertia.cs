using System.Text;
namespace geometry_msgs.msg
{


[System.Serializable]
public class Inertia : Halodi.CDR.DataType<Inertia>
{

	public Halodi.CDR.TopicDataType<Inertia> Type => new InertiaPubSubType();
	
   /**
            * Mass [kg]
            */
   public double m;
   /**
            * Center of mass [m]
            */
   public geometry_msgs.msg.Vector3 com;
   /**
            * Inertia Tensor [kg-m^2]
            * | ixx ixy ixz |
            * I = | ixy iyy iyz |
            * | ixz iyz izz |
            */
   public double ixx;
   public double ixy;
   public double ixz;
   public double iyy;
   public double iyz;
   public double izz;


   public void Set(Inertia other)
   {
      m = other.m;

      geometry_msgs.msg.Vector3PubSubType.Copy(other.com, com);

      ixx = other.ixx;

      ixy = other.ixy;

      ixz = other.ixz;

      iyy = other.iyy;

      iyz = other.iyz;

      izz = other.izz;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("Inertia {");
      builder.Append("m=");
      builder.Append(this.m);      builder.Append(", ");
      builder.Append("com=");
      builder.Append(this.com);      builder.Append(", ");
      builder.Append("ixx=");
      builder.Append(this.ixx);      builder.Append(", ");
      builder.Append("ixy=");
      builder.Append(this.ixy);      builder.Append(", ");
      builder.Append("ixz=");
      builder.Append(this.ixz);      builder.Append(", ");
      builder.Append("iyy=");
      builder.Append(this.iyy);      builder.Append(", ");
      builder.Append("iyz=");
      builder.Append(this.iyz);      builder.Append(", ");
      builder.Append("izz=");
      builder.Append(this.izz);
      builder.Append("}");
      return builder.ToString();
   }
}


}