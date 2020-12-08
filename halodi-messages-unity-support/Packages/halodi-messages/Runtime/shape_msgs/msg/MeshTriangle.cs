using System.Text;
namespace shape_msgs.msg
{


/**
       * Definition of a triangle's vertices.
       */
[System.Serializable]
public class MeshTriangle : Halodi.CDR.DataType<MeshTriangle>
{

	public Halodi.CDR.TopicDataType<MeshTriangle> Type => new MeshTrianglePubSubType();
	


   public void Set(MeshTriangle other)
   {
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("MeshTriangle {");
      builder.Append("}");
      return builder.ToString();
   }
}


}