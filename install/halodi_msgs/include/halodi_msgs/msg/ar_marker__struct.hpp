// generated from rosidl_generator_cpp/resource/idl__struct.hpp.em
// with input from halodi_msgs:msg/ARMarker.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__AR_MARKER__STRUCT_HPP_
#define HALODI_MSGS__MSG__AR_MARKER__STRUCT_HPP_

#include <rosidl_generator_cpp/bounded_vector.hpp>
#include <rosidl_generator_cpp/message_initialization.hpp>
#include <algorithm>
#include <array>
#include <memory>
#include <string>
#include <vector>


// Include directives for member types
// Member 'points'
#include "geometry_msgs/msg/point__struct.hpp"
// Member 'pose'
#include "geometry_msgs/msg/pose_stamped__struct.hpp"

#ifndef _WIN32
# define DEPRECATED__halodi_msgs__msg__ARMarker __attribute__((deprecated))
#else
# define DEPRECATED__halodi_msgs__msg__ARMarker __declspec(deprecated)
#endif

namespace halodi_msgs
{

namespace msg
{

// message struct
template<class ContainerAllocator>
struct ARMarker_
{
  using Type = ARMarker_<ContainerAllocator>;

  explicit ARMarker_(rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  : pose(_init)
  {
    if (rosidl_generator_cpp::MessageInitialization::ALL == _init ||
      rosidl_generator_cpp::MessageInitialization::ZERO == _init)
    {
      this->data = "";
    }
  }

  explicit ARMarker_(const ContainerAllocator & _alloc, rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  : data(_alloc),
    pose(_alloc, _init)
  {
    if (rosidl_generator_cpp::MessageInitialization::ALL == _init ||
      rosidl_generator_cpp::MessageInitialization::ZERO == _init)
    {
      this->data = "";
    }
  }

  // field types and members
  using _data_type =
    std::basic_string<char, std::char_traits<char>, typename ContainerAllocator::template rebind<char>::other>;
  _data_type data;
  using _points_type =
    rosidl_generator_cpp::BoundedVector<geometry_msgs::msg::Point_<ContainerAllocator>, 4, typename ContainerAllocator::template rebind<geometry_msgs::msg::Point_<ContainerAllocator>>::other>;
  _points_type points;
  using _pose_type =
    geometry_msgs::msg::PoseStamped_<ContainerAllocator>;
  _pose_type pose;

  // setters for named parameter idiom
  Type & set__data(
    const std::basic_string<char, std::char_traits<char>, typename ContainerAllocator::template rebind<char>::other> & _arg)
  {
    this->data = _arg;
    return *this;
  }
  Type & set__points(
    const rosidl_generator_cpp::BoundedVector<geometry_msgs::msg::Point_<ContainerAllocator>, 4, typename ContainerAllocator::template rebind<geometry_msgs::msg::Point_<ContainerAllocator>>::other> & _arg)
  {
    this->points = _arg;
    return *this;
  }
  Type & set__pose(
    const geometry_msgs::msg::PoseStamped_<ContainerAllocator> & _arg)
  {
    this->pose = _arg;
    return *this;
  }

  // constant declarations

  // pointer types
  using RawPtr =
    halodi_msgs::msg::ARMarker_<ContainerAllocator> *;
  using ConstRawPtr =
    const halodi_msgs::msg::ARMarker_<ContainerAllocator> *;
  using SharedPtr =
    std::shared_ptr<halodi_msgs::msg::ARMarker_<ContainerAllocator>>;
  using ConstSharedPtr =
    std::shared_ptr<halodi_msgs::msg::ARMarker_<ContainerAllocator> const>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::ARMarker_<ContainerAllocator>>>
  using UniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::ARMarker_<ContainerAllocator>, Deleter>;

  using UniquePtr = UniquePtrWithDeleter<>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::ARMarker_<ContainerAllocator>>>
  using ConstUniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::ARMarker_<ContainerAllocator> const, Deleter>;
  using ConstUniquePtr = ConstUniquePtrWithDeleter<>;

  using WeakPtr =
    std::weak_ptr<halodi_msgs::msg::ARMarker_<ContainerAllocator>>;
  using ConstWeakPtr =
    std::weak_ptr<halodi_msgs::msg::ARMarker_<ContainerAllocator> const>;

  // pointer types similar to ROS 1, use SharedPtr / ConstSharedPtr instead
  // NOTE: Can't use 'using' here because GNU C++ can't parse attributes properly
  typedef DEPRECATED__halodi_msgs__msg__ARMarker
    std::shared_ptr<halodi_msgs::msg::ARMarker_<ContainerAllocator>>
    Ptr;
  typedef DEPRECATED__halodi_msgs__msg__ARMarker
    std::shared_ptr<halodi_msgs::msg::ARMarker_<ContainerAllocator> const>
    ConstPtr;

  // comparison operators
  bool operator==(const ARMarker_ & other) const
  {
    if (this->data != other.data) {
      return false;
    }
    if (this->points != other.points) {
      return false;
    }
    if (this->pose != other.pose) {
      return false;
    }
    return true;
  }
  bool operator!=(const ARMarker_ & other) const
  {
    return !this->operator==(other);
  }
};  // struct ARMarker_

// alias to use template instance with default allocator
using ARMarker =
  halodi_msgs::msg::ARMarker_<std::allocator<void>>;

// constant definitions

}  // namespace msg

}  // namespace halodi_msgs

#endif  // HALODI_MSGS__MSG__AR_MARKER__STRUCT_HPP_
