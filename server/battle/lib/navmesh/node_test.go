package navmesh

import (
	"container/heap"
	"testing"

	. "github.com/smartystreets/goconvey/convey"
)

func TestNodeHeap(t *testing.T) {
	Convey("nodeHeap", t, func() {
		nodeHeap := newNodeHeap([]*node{
			&node{fScore: 10},
			&node{fScore: 3},
			&node{fScore: 5},
		})

		Convey("should implement heap interface", func() {
			So(nodeHeap, ShouldImplement, (*heap.Interface)(nil))
		})

		Convey(".pushNode", func() {
			Convey("push a node with heap sort", func() {
				nodeHeap.pushNode(&node{fScore: 1})
				So(nodeHeap.nodes[0].fScore, ShouldEqual, 1)
			})
		})

		Convey(".popNode", func() {
			Convey("pop a last node", func() {
				n := nodeHeap.popNode()
				So(n.fScore, ShouldEqual, 3)
				So(nodeHeap.Len(), ShouldEqual, 2)
			})
		})
	})
}
