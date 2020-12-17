// generated from rosidl_generator_cpp/resource/idl__struct.hpp.em
// with input from halodi_msgs:srv/GetStampedTF.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__SRV__GET_STAMPED_TF__STRUCT_HPP_
#define HALODI_MSGS__SRV__GET_STAMPED_TF__STRUCT_HPP_

#include <rosidl_generator_cpp/bounded_vector.hpp>
#include <rosidl_generator_cpp/message_initialization.hpp>
#include <algorithm>
#include <array>
#include <memory>
#include <string>
#include <vector>


#ifndef _WIN32
# define DEPRECATED__halodi_msgs__srv__GetStampedTF_Request __attribute__((deprecated))
#else
# define DEPRECATED__halodi_msgs__srv__GetStampedTF_Request __declspec(deprecated)
#endif

namespace halodi_msgs
{

namespace srv
{

// message struct
template<class ContainerAllocator>
struct GetStampedTF_Request_
{
  using Type = GetStampedTF_Request_<ContainerAllocator>;

  explicit GetStampedTF_Request_(rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  {
    if (rosidl_generator_cpp::MessageInitialization::ALL == _init ||
      rosidl_generator_cpp::MessageInitialization::ZERO == _init)
    {
      this->monotonic_stamp = 0.0;
      this->parent_frame = "";
      this->child_frame = "";
    }
  }

  explicit GetStampedTF_Request_(const ContainerAllocator & _alloc, rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  : parent_frame(_alloc),
    child_frame(_alloc)
  {
    if (rosidl_generator_cpp::MessageInitialization::ALL == _init ||
      rosidl_generator_cpp::MessageInitialization::ZERO == _init)
    {
      this->monotonic_stamp = 0.0;
      this->parent_frame = "";
      this->child_frame = "";
    }
  }

  // field types and members
  using _monotonic_stamp_type =
    double;
  _monotonic_stamp_type monotonic_stamp;
  using _parent_frame_type =
    std::basic_string<char, std::char_traits<char>, typename ContainerAllocator::template rebind<char>::other>;
  _parent_frame_type parent_frame;
  using _child_frame_type =
    std::basic_string<char, std::char_traits<char>, typename ContainerAllocator::template rebind<char>::other>;
  _child_frame_type child_frame;

  // setters for named parameter idiom
  Type & set__monotonic_stamp(
    const double & _arg)
  {
    this->monotonic_stamp = _arg;
    return *this;
  }
  Type & set__parent_frame(
    const std::basic_string<char, std::char_traits<char>, typename ContainerAllocator::template rebind<char>::other> & _arg)
  {
    this->parent_frame = _arg;
    return *this;
  }
  Type & set__child_frame(
    const std::basic_string<char, std::char_traits<char>, typename ContainerAllocator::template rebind<char>::other> & _arg)
  {
    this->child_frame = _arg;
    return *this;
  }

  // constant declarations

  // pointer types
  using RawPtr =
    halodi_msgs::srv::GetStampedTF_Request_<ContainerAllocator> *;
  using ConstRawPtr =
    const halodi_msgs::srv::GetStampedTF_Request_<ContainerAllocator> *;
  using SharedPtr =
    std::shared_ptr<halodi_msgs::srv::GetStampedTF_Request_<ContainerAllocator>>;
  using ConstSharedPtr =
    std::shared_ptr<halodi_msgs::srv::GetStampedTF_Request_<ContainerAllocator> const>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::srv::GetStampedTF_Request_<ContainerAllocator>>>
  using UniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::srv::GetStampedTF_Request_<ContainerAllocator>, Deleter>;

  using UniquePtr = UniquePtrWithDeleter<>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::srv::GetStampedTF_Request_<ContainerAllocator>>>
  using ConstUniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::srv::GetStampedTF_Request_<ContainerAllocator> const, Deleter>;
  using ConstUniquePtr = ConstUniquePtrWithDeleter<>;

  using WeakPtr =
    std::weak_ptr<halodi_msgs::srv::GetStampedTF_Request_<ContainerAllocator>>;
  using ConstWeakPtr =
    std::weak_ptr<halodi_msgs::srv::GetStampedTF_Request_<ContainerAllocator> const>;

  // pointer types similar to ROS 1, use SharedPtr / ConstSharedPtr instead
  // NOTE: Can't use 'using' here because GNU C++ can't parse attributes properly
  typedef DEPRECATED__halodi_msgs__srv__GetStampedTF_Request
    std::shared_ptr<halodi_msgs::srv::GetStampedTF_Request_<ContainerAllocator>>
    Ptr;
  typedef DEPRECATED__halodi_msgs__srv__GetStampedTF_Request
    std::shared_ptr<halodi_msgs::srv::GetStampedTF_Request_<ContainerAllocator> const>
    ConstPtr;

  // comparison operators
  bool operator==(const GetStampedTF_Request_ & other) const
  {
    if (this->monotonic_stamp != other.monotonic_stamp) {
      return false;
    }
    if (this->parent_frame != other.parent_frame) {
      return false;
    }
    if (this->child_frame != other.child_frame) {
      return false;
    }
    return true;
  }
  bool operator!=(const GetStampedTF_Request_ & other) const
  {
    return !this->operator==(other);
  }
};  // struct GetStampedTF_Request_

// alias to use template instance with default allocator
using GetStampedTF_Request =
  halodi_msgs::srv::GetStampedTF_Request_<std::allocator<void>>;

// constant definitions

}  // namespace srv

}  // namespace halodi_msgs


// Include directives for member types
// Member 'stf'
#include "geometry_msgs/msg/transform_stamped__struct.hpp"

#ifndef _WIN32
# define DEPRECATED__halodi_msgs__srv__GetStampedTF_Response __attribute__((deprecated))
#else
# define DEPRECATED__halodi_msgs__srv__GetStampedTF_Response __declspec(deprecated)
#endif

namespace halodi_msgs
{

namespace srv
{

// message struct
template<class ContainerAllocator>
struct GetStampedTF_Response_
{
  using Type = GetStampedTF_Response_<ContainerAllocator>;

  explicit GetStampedTF_Response_(rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  : stf(_init)
  {
    if (rosidl_generator_cpp::MessageInitialization::ALL == _init ||
      rosidl_generator_cpp::MessageInitialization::ZERO == _init)
    {
      this->ok = false;
    }
  }

  explicit GetStampedTF_Response_(const ContainerAllocator & _alloc, rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  : stf(_alloc, _init)
  {
    if (rosidl_generator_cpp::MessageInitialization::ALL == _init ||
      rosidl_generator_cpp::MessageInitialization::ZERO == _init)
    {
      this->ok = false;
    }
  }

  // field types and members
  using _ok_type =
    bool;
  _ok_type ok;
  using _stf_type =
    geometry_msgs::msg::TransformStamped_<ContainerAllocator>;
  _stf_type stf;

  // setters for named parameter idiom
  Type & set__ok(
    const bool & _arg)
  {
    this->ok = _arg;
    return *this;
  }
  Type & set__stf(
    const geometry_msgs::msg::TransformStamped_<ContainerAllocator> & _arg)
  {
    this->stf = _arg;
    return *this;
  }

  // constant declarations

  // pointer types
  using RawPtr =
    halodi_msgs::srv::GetStampedTF_Response_<ContainerAllocator> *;
  using ConstRawPtr =
    const halodi_msgs::srv::GetStampedTF_Response_<ContainerAllocator> *;
  using SharedPtr =
    std::shared_ptr<halodi_msgs::srv::GetStampedTF_Response_<ContainerAllocator>>;
  using ConstSharedPtr =
    std::shared_ptr<halodi_msgs::srv::GetStampedTF_Response_<ContainerAllocator> const>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::srv::GetStampedTF_Response_<ContainerAllocator>>>
  using UniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::srv::GetStampedTF_Response_<ContainerAllocator>, Deleter>;

  using UniquePtr = UniquePtrWithDeleter<>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::srv::GetStampedTF_Response_<ContainerAllocator>>>
  using ConstUniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::srv::GetStampedTF_Response_<ContainerAllocator> const, Deleter>;
  using ConstUniquePtr = ConstUniquePtrWithDeleter<>;

  using WeakPtr =
    std::weak_ptr<halodi_msgs::srv::GetStampedTF_Response_<ContainerAllocator>>;
  using ConstWeakPtr =
    std::weak_ptr<halodi_msgs::srv::GetStampedTF_Response_<ContainerAllocator> const>;

  // pointer types similar to ROS 1, use SharedPtr / ConstSharedPtr instead
  // NOTE: Can't use 'using' here because GNU C++ can't parse attributes properly
  typedef DEPRECATED__halodi_msgs__srv__GetStampedTF_Response
    std::shared_ptr<halodi_msgs::srv::GetStampedTF_Response_<ContainerAllocator>>
    Ptr;
  typedef DEPRECATED__halodi_msgs__srv__GetStampedTF_Response
    std::shared_ptr<halodi_msgs::srv::GetStampedTF_Response_<ContainerAllocator> const>
    ConstPtr;

  // comparison operators
  bool operator==(const GetStampedTF_Response_ & other) const
  {
    if (this->ok != other.ok) {
      return false;
    }
    if (this->stf != other.stf) {
      return false;
    }
    return true;
  }
  bool operator!=(const GetStampedTF_Response_ & other) const
  {
    return !this->operator==(other);
  }
};  // struct GetStampedTF_Response_

// alias to use template instance with default allocator
using GetStampedTF_Response =
  halodi_msgs::srv::GetStampedTF_Response_<std::allocator<void>>;

// constant definitions

}  // namespace srv

}  // namespace halodi_msgs

namespace halodi_msgs
{

namespace srv
{

struct GetStampedTF
{
  using Request = halodi_msgs::srv::GetStampedTF_Request;
  using Response = halodi_msgs::srv::GetStampedTF_Response;
};

}  // namespace srv

}  // namespace halodi_msgs

#endif  // HALODI_MSGS__SRV__GET_STAMPED_TF__STRUCT_HPP_
