using System.Text;
namespace rcl_interfaces.msg
{


[System.Serializable]
public class ListParametersResult
{
   /**
            * All parameters under the given prefixes.
            */
   public System.Collections.Generic.List<string> names;
   /**
            * All prefixes under the given prefixes.
            * TODO(wjwwood): link to prefix definition and rules.
            */
   public System.Collections.Generic.List<string> prefixes;


   public void Set(ListParametersResult other)
   {

      if(other.names == null)
      {
      	names = null;
      }
      else
      {
      	names = new System.Collections.Generic.List<string>(other.names.Count);
      	for(int i1 = 0; i1 < other.names.Count; i1++)
      	{
         		names.Add(other.names[i1]);
      	}
      }

      if(other.prefixes == null)
      {
      	prefixes = null;
      }
      else
      {
      	prefixes = new System.Collections.Generic.List<string>(other.prefixes.Count);
      	for(int i2 = 0; i2 < other.prefixes.Count; i2++)
      	{
         		prefixes.Add(other.prefixes[i2]);
      	}
      }
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("ListParametersResult {");
      builder.Append("names=");
      builder.Append(this.names);      builder.Append(", ");
      builder.Append("prefixes=");
      builder.Append(this.prefixes);
      builder.Append("}");
      return builder.ToString();
   }
}


}