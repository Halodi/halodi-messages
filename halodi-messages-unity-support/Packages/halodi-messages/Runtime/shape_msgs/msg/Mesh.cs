using System.Text;
namespace shape_msgs.msg
{


/**
       * Definition of a mesh.
       */
[System.Serializable]
public class Mesh : Halodi.CDR.DataType<Mesh>
{

	public Halodi.CDR.TopicDataType<Mesh> Type => new MeshPubSubType();
	
   /**
            * List of triangles; the index values refer to positions in vertices[].
            */
   public System.Collections.Generic.List<shape_msgs.msg.MeshTriangle> triangles;
   /**
            * The actual vertices that make up the mesh.
            */
   public System.Collections.Generic.List<geometry_msgs.msg.Point> vertices;


   public void Set(Mesh other)
   {

      if(other.triangles == null)
      {
      	triangles = null;
      }
      else
      {
      	triangles = new System.Collections.Generic.List<shape_msgs.msg.MeshTriangle>(other.triangles.Count);
      	for(int i1 = 0; i1 < other.triangles.Count; i1++)
      	{
      		if(other.triangles[i1] == null)
      		{
      			triangles.Add(null);
      		}
      		else
      		{
      			shape_msgs.msg.MeshTriangle newElement = shape_msgs.msg.MeshTrianglePubSubType.Create();
      	   		shape_msgs.msg.MeshTrianglePubSubType.Copy(other.triangles[i1], newElement);
      	   		triangles.Add(newElement);
      		}	}
      }

      if(other.vertices == null)
      {
      	vertices = null;
      }
      else
      {
      	vertices = new System.Collections.Generic.List<geometry_msgs.msg.Point>(other.vertices.Count);
      	for(int i2 = 0; i2 < other.vertices.Count; i2++)
      	{
      		if(other.vertices[i2] == null)
      		{
      			vertices.Add(null);
      		}
      		else
      		{
      			geometry_msgs.msg.Point newElement = geometry_msgs.msg.PointPubSubType.Create();
      	   		geometry_msgs.msg.PointPubSubType.Copy(other.vertices[i2], newElement);
      	   		vertices.Add(newElement);
      		}	}
      }
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("Mesh {");
      builder.Append("triangles=");
      builder.Append(this.triangles);      builder.Append(", ");
      builder.Append("vertices=");
      builder.Append(this.vertices);
      builder.Append("}");
      return builder.ToString();
   }
}


}